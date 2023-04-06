using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // Vitesse de déplacement

    public Transform[] destinations;
    int currentIndex = 0; // L'index de la destination actuelle dans le tableau "destinations"
    private Vector3 target; // Position cible

    void Start()
    {
        // Positionnement initial de la lumière
        transform.position = destinations[0].position;

        // Position cible pour commencer
        target = destinations[1].position;
    }

    void Update()
    {
        // Déplacement vers la position cible
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Si la position cible est atteinte, passer à la prochaine destination
        if (transform.position == target)
        {
            currentIndex = (currentIndex + 1) % destinations.Length;
            target = destinations[currentIndex].position;
        }
    }
}

