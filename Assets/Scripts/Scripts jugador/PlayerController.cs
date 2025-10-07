using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(1, 0, 0);
        float speed = 10.0f;
        transform.Translate(movement
            * speed
            * Time.deltaTime, Space.World);
    }
}
