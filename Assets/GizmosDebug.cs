using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosDebug : MonoBehaviour
{
    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Color c = Color.yellow;
        c.a = 0.25f;

        Gizmos.color = c;

        Gizmos.DrawSphere(transform.position, 0.25f);
    }
}
