using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10f;              // Velocidad del tri�ngulo
    public float directionChangeTime = 1f; // Tiempo entre cambios de direcci�n

    private Vector2 direction;
    private float timer;
    private Camera mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
        PickNewDirection();
    }


    void PickNewDirection()
    {
       direction = Random.insideUnitCircle.normalized;
       timer = directionChangeTime;
    }



   
    void KeepInsideCamera()
    {
        // Convertir posici�n a viewport (0..1)
        Vector3 viewportPos = mainCamera.WorldToViewportPoint(transform.position);
        // Clamp para que quede dentro de la c�mara
        viewportPos.x = Mathf.Clamp(viewportPos.x, 0.05f, 0.95f);
        viewportPos.y = Mathf.Clamp(viewportPos.y, 0.05f, 0.95f);
        // Convertir de nuevo a coordenadas del mundo
        transform.position = mainCamera.ViewportToWorldPoint(viewportPos);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        // Mantener dentro de c�mara
        KeepInsideCamera();

        // Temporizador para cambiar direcci�n
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            PickNewDirection();
        }
    }

}
