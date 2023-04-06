using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class grappin : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Grapp"))
                {
                    Vector3 positionJoueur = transform.position;
                    Vector3 positionCamera = Camera.main.transform.position;
                    Vector3 directionCamera = Camera.main.transform.forward;
                    Vector3 déplacementJoueur = positionCamera + (2 * directionCamera);
                    //Vector3 positionProjectile2 = positionCamera + (2 * directionCamera);//
                    //Vector3 positionProjectile = positionJoueur + positionSphere;//
                    //Instantiate(Sphere, positionProjectile2, Camera.main.transform.rotation);//
                }
            }
        }
    }
}
