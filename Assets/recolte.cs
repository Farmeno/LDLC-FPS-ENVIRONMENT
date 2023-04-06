using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.InputSystem;


public class recolte : MonoBehaviour
{
    public Camera camera;
    public int score;
    public string affiche_score;
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
                if(hit.collider.CompareTag("Cube"))
                {

                Debug.Log("Hello");
                score += 1;
                affiche_score = score + "/?" ;
                GetComponent<TMP_Text>().text = affiche_score;

                    Destroy(hit.collider.gameObject, 1f);

                }
                if (score > 3)
                 {
                    affiche_score = score + "/" + score;
                    GetComponent<TMP_Text>().text = affiche_score;
                }

            }
        }




    }
}
