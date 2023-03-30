using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class projectilejoueur : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Cube;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   


    // Update is called once per frame
    void Update()
    {
        //Effectuer une action lorsque l'utilisateur clique (dans l'Update) :
        Vector3 positionSphere = new Vector3(0f, 0f, 2f);
       
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 positionJoueur = transform.position;
            Vector3 positionCamera = Camera.main.transform.position;
            Vector3 directionCamera = Camera.main.transform.forward;
            Vector3 positionProjectile2 = positionCamera + (2*directionCamera);
            Vector3 positionProjectile = positionJoueur + positionSphere;
            Instantiate(Sphere, positionProjectile2, Camera.main.transform.rotation);
            Vector3 positionCube = Cube.transform.position;
        }
    }
}
