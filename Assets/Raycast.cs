using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class Raycast : MonoBehaviour
{
    public Camera camera;
    public GameObject Cylinder;


    void Start()
    {
        
    }
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());


        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Debug.Log("Hello");

            Vector3 positionCamera = Camera.main.transform.position;
            Vector3 directionCamera = Camera.main.transform.forward;
            Vector3 Cylindre = positionCamera + (2 * directionCamera); 

            // Do something with the object that was hit by the raycast.
        }
    }

}