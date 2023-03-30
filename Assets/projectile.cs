using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = transform.forward;
        Vector3 currentPosition = transform.position;
        float speed = 10f;
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;
        rigidbody.MovePosition(newPosition);
    }
}
