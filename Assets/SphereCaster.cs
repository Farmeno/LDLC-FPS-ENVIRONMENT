using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCaster : MonoBehaviour
{
    public float sphereRadius;
    public float Distance;
    public LayerMask layerMask;
    public GameObject Hélico;
    public GameObject currentHitObject;
    private Vector3 PositionJoueur;
    

    // Start is called before the first frame update
    void Start()
    {
        PositionJoueur = currentHitObject.transform.position;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        RaycastHit hit;
        if (Physics.SphereCast(origin, sphereRadius, direction, out hit, Distance, layerMask, QueryTriggerInteraction.UseGlobal))
        {
            currentHitObject = hit.transform.gameObject;
            currentHitObject.transform.position = PositionJoueur; 
        }
    }
}
