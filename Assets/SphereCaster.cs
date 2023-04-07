using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class SphereCaster : MonoBehaviour
{
    float sphereRadius;
    public float Distance;
    public LayerMask layerMask;
    float morts = 0;
    public TMP_Text morts2;

    public bool isWorking = true;
    Light _light;

    Light Light
    {
        get
        {
            if (_light == null)
                _light = GetComponent<Light>();
            return _light;
        }
    }

    void Update()
    {
        sphereRadius = Mathf.Tan(Light.spotAngle * 0.5f * Mathf.Deg2Rad) * transform.position.y;

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
            Debug.Log("SALUT");
            GameObject currentHitObject = hit.transform.gameObject;
            Debug.Log(currentHitObject);

            currentHitObject.transform.position = GameManager.Instance.spawnPoint.position;
            morts = morts + 1;
            morts2.text = "Morts = "+morts;

        }
    }

    private void OnDrawGizmosSelected()
    {
        Color c = Color.red;
        c.a = 0.5f;
        Gizmos.color = c;
        
            Gizmos.DrawSphere(transform.position + transform.forward * transform.position.y, sphereRadius);
        
    }
}
