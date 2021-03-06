using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

/// <summary>
/// The DeathLaser class emits a raycast that kills the player on contact.
/// </summary>
public class DeathLaser : MonoBehaviour
{
    #region Inspector fields
    [Tooltip("Only want to kill the player.")]
    [SerializeField] private LayerMask _onlyPlayer;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // Set up the line renderer
        LineRenderer line = gameObject.AddComponent<LineRenderer>();
        line.useWorldSpace = true;
        line.material = new Material(Shader.Find("Unlit/Color"));
        
        line.material.color = Color.red;
        line.startWidth = 0.1f;
        line.endWidth = line.startWidth;
        line.receiveShadows = false;
        line.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        line.positionCount = 2;

        Vector3[] points = new Vector3[]{transform.GetChild(0).position, transform.GetChild(1).position};
        line.SetPositions(points);
    }

    void Update()
    {
        // Raycast between the two nodes
        Vector2 raycastDirection = transform.GetChild(1).position - transform.GetChild(0).position;
        float raycastDistance = Vector3.Distance(transform.GetChild(0).position, transform.GetChild(1).position);

        RaycastHit2D hit = Physics2D.Raycast(transform.GetChild(0).position, raycastDirection, raycastDistance, _onlyPlayer);
        if(hit)
        {
            PlayerStatus ps = hit.collider.GetComponent<PlayerStatus>();
            if(ps)
            {
                ps.Die();
            }
        }
    }
}
