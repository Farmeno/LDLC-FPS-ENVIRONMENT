using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCaster : MonoBehaviour
{
    public float sphereRadius;
    public float Distance;
    public LayerMask layerMask;

    public bool isWorking = true;
    // Start is called before the first frame update
    void Start()
    {
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isWorking)
            return; 

        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        RaycastHit hit;
        if (Physics.SphereCast(origin, sphereRadius, direction, out hit, Distance, layerMask, QueryTriggerInteraction.UseGlobal))
        {
            GameObject currentHitObject = hit.transform.gameObject;
            currentHitObject.transform.position = GameManager.Instance.spawnPoint.position; 
        }
    }
}
