using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    #region Inspector fields
    [SerializeField] private float lightMass;

    [SerializeField] private float heavyMass;

    [SerializeField] private PhysicsMaterial2D bounceMaterial;
    [SerializeField] private float initialBounceHeight = 10;

    [SerializeField] private float floatHeight;

    [SerializeField] private float floatSpeed;

    #endregion

    #region  Private fields
    private static List<PhysicsObject> allPhysicsObjects;
    private Transform originalParent;
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;
    private float initialMass;
    private Vector3 recordingStartPosition;
    private PhysicsMaterial2D initialPhysicsMaterial;
    private float yPosOnGround;
    private float yPosInAir;
    private bool touchingCeiling;
    private Coroutine floatRoutine;
    #endregion

    void Awake()
    {
        if (allPhysicsObjects == null) allPhysicsObjects = new List<PhysicsObject>();
    }

    void Start()
    {
        originalParent = transform;
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        initialMass = rigidbody2D.mass;
        recordingStartPosition = transform.position;
        initialPhysicsMaterial = rigidbody2D.sharedMaterial;
        yPosOnGround = transform.position.y;
        allPhysicsObjects.Add(this);
    }

    void Update()
    {
        if (rigidbody2D.gravityScale == 0 && floatRoutine == null)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
        }
    }

    public void UpdateRecordingStartPosition()
    {
        recordingStartPosition = transform.position;
    }

    void ResetPhysics(bool resetVelocity)
    {
        if(resetVelocity) rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.isKinematic = false;
        rigidbody2D.mass = initialMass;
        rigidbody2D.sharedMaterial = initialPhysicsMaterial;
        rigidbody2D.gravityScale = 1;
        if (floatRoutine != null) StopCoroutine(floatRoutine);

        spriteRenderer.color = Color.white;
    }

    public void ResetParent()
    {
        transform.parent = originalParent;
    }

    public static void UpdateAllInitialPositions()
    {
        if (allPhysicsObjects != null)
        {
            foreach (PhysicsObject physicsObject in allPhysicsObjects)
            {
                physicsObject.UpdateRecordingStartPosition();
            }
        }
    }

    public static void ResetAllPhysics(bool resetPosition, bool resetVelocity)
    {
        if (allPhysicsObjects != null)
        {
            foreach (PhysicsObject physicsObject in allPhysicsObjects)
            {
                physicsObject.ResetPhysics(resetVelocity);
                if (resetPosition) 
                {
                    physicsObject.transform.position = physicsObject.recordingStartPosition;
                    physicsObject.yPosOnGround = physicsObject.transform.position.y;
                }
            }
        }
    }

    void MakeLight()
    {
        rigidbody2D.mass = lightMass;
        spriteRenderer.color = Color.cyan;
    }

    void MakeHeavy()
    {
        rigidbody2D.mass = heavyMass;
        spriteRenderer.color = Color.red;
    }

    void MakeBouncy()
    {
        rigidbody2D.sharedMaterial = bounceMaterial;
        rigidbody2D.drag = 0;

        //Starting bounce if the object was stationary
        if (Mathf.Abs(rigidbody2D.velocity.y) < 1 &&
            Mathf.Abs(transform.position.y - yPosOnGround) < 0.1f)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, initialBounceHeight);
        }

        spriteRenderer.color = Color.green;
    }

    void MakeFloat()
    {
        yPosInAir = yPosOnGround + floatHeight;
        floatRoutine = StartCoroutine(GoUp());
        rigidbody2D.gravityScale = 0;
        spriteRenderer.color = Color.yellow;
    }

    IEnumerator GoUp()
    {
        while (transform.position.y < yPosInAir)
        {
            rigidbody2D.velocity = new Vector2(0, floatSpeed);
            yield return null;
        }
        floatRoutine = null;
    }

    public void AlterPhysics(PhysicsRay.RayType rayType)
    {
        ResetAllPhysics(false, false);
        switch (rayType)
        {
            case PhysicsRay.RayType.Light:
                {
                    MakeLight();
                    break;
                }

            case PhysicsRay.RayType.Heavy:
                {
                    MakeHeavy();
                    break;
                }

            case PhysicsRay.RayType.Bouncy:
                {
                    MakeBouncy();
                    break;
                }

            case PhysicsRay.RayType.Float:
                {
                    MakeFloat();
                    break;
                }
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        ContactPoint2D[] contacts = new ContactPoint2D[other.contactCount];
        other.GetContacts(contacts);

        foreach(ContactPoint2D contact in contacts)
        {
            if(contact.normal == Vector2.up && rigidbody2D.gravityScale > 0)
            {
                yPosOnGround = transform.position.y;
            }
        }
    }
    void OnDestroy()
    {
        allPhysicsObjects.Remove(this);
    }
}