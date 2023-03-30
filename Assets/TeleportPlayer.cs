using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public float teleportHeight = -10; 
    public Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        
        if (transform.position.y < teleportHeight)
        {
            
            transform.position = initialPosition;
        }
    }
}