using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    Vector3 stopMovement = new Vector3(-10f, 6.06f, 9.51f);
    Vector3 initialPosition = new Vector3(1.69f, 6.06f, 9.51f);  
    Vector3 direction = new Vector3(-1f, 0f, 0f);
    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
      
        
        float speed = 2f;

        if(currentPosition.x >= stopMovement.x)
        {
            if(direction.x == -1f)
            {
                direction.x = -1f;
            }
        }
        else if(currentPosition.x <= initialPosition.x)
        {
            if(direction.x == -1f)
            {
                direction.x = 1f;
            }
            

        }



        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        rigidbody.MovePosition(newPosition);

        Debug.Log(currentPosition);

    }
}
