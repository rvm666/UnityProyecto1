using UnityEngine;

public class BossController : MonoBehaviour
{


    public float speed = 5f;          // Velocidad del enemigo
    public Transform player;           // Referencia al jugador
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            
        player = playerObj.transform;
        
    }

    void Update()
    {
        if (player == null) return; // Si no hay jugador, no hacer nada

        // Calcular dirección hacia el jugador
        Vector2 direction = (player.position - transform.position).normalized;

        // Mover hacia el jugador
        transform.Translate(direction * speed * Time.deltaTime);
    }

   
}

