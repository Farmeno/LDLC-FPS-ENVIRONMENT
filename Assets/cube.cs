using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction = new Vector3(0f, 0f, 1f);
        float speed = 2f;

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}
