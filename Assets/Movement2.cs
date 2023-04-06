using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed = 5.0f; // Vitesse de déplacement

    private float timer = 0.0f; // Chronomètre

    public Color red = Color.red;
    public Color green = Color.green;
    public Color black = Color.black;

    void Start()
    {
    }

    void Update()
    {
        // Chronomètre
        timer += Time.deltaTime;


        // Si le chronomètre dépasse 10 secondes
        if (timer > 10.0f)
        {
            // Alterner le matériel entre rouge et rien toutes les 0.1 secondes pendant 5 secondes
            if (timer < 15.0f)
            {
                float t = timer - 10.0f;
                float r = Mathf.PingPong(t * 10.0f, 1.0f);
                if (r > 0.5f)
                {
                    gameObject.GetComponent<Renderer>().material.color = red;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = black;
                }
            }
            // La lumière reste verte pendant 5 secondes
            else if (timer < 20.0f)
            {
                gameObject.GetComponent<Renderer>().material.color = green;
                GetComponent<SphereCaster>().isWorking = false;
            }
            // Alterner le matériel entre vert et rien toutes les 0.1 secondes pendant 5 secondes
            else if (timer < 25.0f)
            {
                float t = timer - 20.0f;
                float r = Mathf.PingPong(t * 10.0f, 1.0f);
                if (r > 0.5f)
                {
                    gameObject.GetComponent<Renderer>().material.color = green;
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = black;
                }
            }
            // La lumière est rouge pendant 5 secondes
            else if (timer < 30.0f)
            {
                gameObject.GetComponent<Renderer>().material.color = red;
                GetComponent<SphereCaster>().isWorking = true;
                timer = 0f;
            }
        }
    }
}
