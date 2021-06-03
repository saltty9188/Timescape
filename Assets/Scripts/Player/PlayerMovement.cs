﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region Inspector fields
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;
    [SerializeField] private float knockBackSpeed = 6;
    [SerializeField] private float knockBackDuration = 0.25f;
    [SerializeField] private float boxGrabDistance = 0.75f;
    [SerializeField] private LayerMask allButPlayer;
    #endregion

    #region Public fields
    public bool PushingBox
    {
        get {return nearBox;}
    }
    #endregion

    #region Private fields
    private Aim aimScript;
    private ToolTips toolTips;
    private Rigidbody2D rigidbody;
    private Animator animator;
    private Vector2 playerSize;
    private GameObject nearbyLadder;
    private bool betweenTwoLadders;
    private bool onLadder;
    private bool grounded;
    private bool facingRight;
    private bool nearBox;
    private Transform originalParent;
    protected float knockBackTime;
    protected Vector2 knockBackDirection;

    private bool _conntectedToBox;
    #endregion

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        playerSize = GetComponent<CapsuleCollider2D>().size;
        originalParent = transform.parent;
        aimScript = transform.GetChild(0).GetComponent<Aim>();
        toolTips = GetComponent<ToolTips>();
    }

    void FixedUpdate()
    {
        bool wasGrounded = grounded;

        //Disable jump animation upon landing
        if(grounded)// && wasGrounded) 
        {
            animator.SetBool("Jump", false); 
        } 
    }

    public void move(Vector2 movement, bool jumping, bool grabbing)
    {

        if(this.enabled)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right * transform.localScale.x, boxGrabDistance, allButPlayer);

            nearBox = hit && hit.collider.tag == "Box";

            if(aimScript.CurrentWeapon == null && !nearBox)
            {
                aimScript.gameObject.SetActive(false);
                aimScript.enabled = false;
            }
            else
            {
                aimScript.gameObject.SetActive(true);
                aimScript.enabled = true;
            }

            animator.SetBool("HasWeapon", aimScript.gameObject.activeSelf);

            // Set grab tool tip for the player only
            if(tag == "Player") toolTips.GrabToolTip(nearBox);
            aimScript.GrabArm(nearBox);

            if(nearBox)
            {
                FixedJoint2D joint = hit.collider.GetComponent<FixedJoint2D>();
                if(grabbing && grounded && Mathf.Abs(hit.collider.GetComponent<Rigidbody2D>().velocity.y) <= 0.1f)
                {
                    joint.enabled = true;
                    joint.connectedBody = rigidbody;
                    aimScript.enabled = false;
                    _conntectedToBox = true;
                }
                else
                {
                    joint.enabled = false;
                    joint.connectedBody = null;
                    aimScript.enabled = true;
                    _conntectedToBox = false;
                }
            }

            if(knockBackTime > 0)
            {
                knockBackTime -= Time.deltaTime;
                rigidbody.velocity = new Vector2(knockBackDirection.x * knockBackSpeed, rigidbody.velocity.y);
                animator.SetFloat("Speed", 0);
            }
            else
            {

                if(nearbyLadder && ((movement.y > 0.5 && transform.position.y < nearbyLadder.transform.GetChild(0).position.y)
                    || movement.y < -0.5 && transform.position.y > nearbyLadder.transform.position.y))
                {
                    onLadder = true;
                    transform.position = new Vector3(nearbyLadder.transform.position.x, transform.position.y, transform.position.z);
                }

                if(onLadder && nearbyLadder)
                {
                    ClimbLadder(movement, jumping);
                }
                else
                {
                    OffLadder();
                    rigidbody.velocity = new Vector2(movement.x * moveSpeed, rigidbody.velocity.y);
                    if(!aimScript.gameObject.activeSelf)
                    {
                        facingRight = transform.localScale.x > 0;
                        if(movement.x < 0 && facingRight)
                        {
                            Debug.Log(facingRight);
                            Flip();
                        }
                        else if(movement.x > 0 && !facingRight)
                        {
                            Flip();
                        }
                    }
                    else
                    {
                        bool runningBackwards = movement.x * transform.localScale.x < 0;
                        animator.SetBool("RunningBackwards", runningBackwards);
                    }

                    //Put in if statement so it doesn't get reset until the player hits the ground
                    if(jumping && grounded && !_conntectedToBox)
                    {
                        Jump();
                    }

                    animator.SetFloat("Speed", Mathf.Abs(movement.x));
                }
            }
        }
    }

    void ClimbLadder(Vector2 movement, bool jumping)
    {
        SetArmActive(false);
        animator.SetBool("OnLadder", onLadder);
        animator.SetBool("Jump", false);
        rigidbody.isKinematic = true;
        rigidbody.velocity = new Vector2(0, 0);
        transform.Translate(0, movement.y * moveSpeed * Time.deltaTime, 0, Space.World);

        if(movement.y == 0)
        {
            animator.enabled = false;
        }
        else
        {
            animator.enabled = true;
        }

        if(jumping)
        {
            rigidbody.isKinematic = false;
            animator.enabled = true;
            onLadder = false;
            animator.SetBool("OnLadder", onLadder);
            animator.SetFloat("Speed", 0);
            Jump();
        }
        else if(transform.position.y - playerSize.y / 2 >= nearbyLadder.transform.GetChild(0).position.y && movement.y >= 0)
        {
            //transform.position = new Vector3(transform.position.x, nearbyLadder.transform.GetChild(0).position.y + playerSize.y / 2, transform.position.z);
            rigidbody.isKinematic = false;
            onLadder = false;
            animator.SetBool("OnLadder", onLadder);
        }
        else if((transform.position.y - playerSize.y / 2) <= (nearbyLadder.transform.GetChild(1).position.y) && movement.y <= 0)
        {
            rigidbody.isKinematic = false;
            onLadder = false;
            animator.SetBool("OnLadder", onLadder);
        }
    }

    void Jump()
    {
        rigidbody.drag = 0;
        rigidbody.AddForce(new Vector2(0, jumpPower));
        grounded = false;
        animator.SetBool("Jump", true);
        AudioManager.Instance.PlaySFX("PlayerJump");
    }

    void SetArmActive(bool active)
    {
        transform.GetChild(0).GetComponent<Aim>().enabled = active;
        transform.GetChild(0).gameObject.SetActive(active);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Lift l = other.GetContact(0).collider.GetComponent<Lift>();
        if(l != null)
        {
            transform.parent = other.GetContact(0).collider.transform;
        }

        float angle = Vector2.Angle(other.GetContact(0).normal, Vector2.up);

        PhysicsObject po = other.GetContact(0).collider.GetComponent<PhysicsObject>();
        if(po && angle < 45)
        {
            transform.parent = other.GetContact(0).collider.transform;
        }

    }

    void OnCollisionStay2D(Collision2D other)
    {
        ContactPoint2D[] contacts = new ContactPoint2D[other.contactCount];
        other.GetContacts(contacts);

        foreach(ContactPoint2D contact in contacts)
        {
            float angle = Vector2.Angle(contact.normal, Vector2.up);

            if(angle < 40) {
                grounded = true; 
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        transform.parent = originalParent;
        grounded = false;
    }  

    public void ReceiveKnockBack(Vector2 direction)
    {
        knockBackTime = knockBackDuration;
        knockBackDirection = direction;
    }

    public void OffLadder()
    {
        animator.enabled = true;
        rigidbody.isKinematic = false;
        rigidbody.useFullKinematicContacts = false;
        onLadder = false;
        animator.SetBool("OnLadder", onLadder);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ladder")
        {
            if(nearbyLadder)
            {
                betweenTwoLadders = true;
            }
            nearbyLadder = other.gameObject;
        }    
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Ladder")
        {
            if(betweenTwoLadders)
            {
                betweenTwoLadders = false;
            }
            else
            {
                nearbyLadder = null;
            }
        }
    }

    void Flip()
    {
        Vector3 temp = gameObject.transform.localScale;
        temp.x *= -1;
        gameObject.transform.localScale = temp;
    }
}
