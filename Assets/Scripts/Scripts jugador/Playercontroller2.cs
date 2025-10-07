using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller2 : MonoBehaviour
{
    private Vector2 movementInput;
    public float speed = 1f;
    void Start()
    {
        
    }
    
    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(movementInput.x, movementInput.y, 0f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
