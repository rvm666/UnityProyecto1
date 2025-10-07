using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller2 : MonoBehaviour
{
    private Vector2 movementInput;
    Rigidbody2D rb;
    public float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
        //movementInput.x = Input.GetAxisRaw("Horizontal");
        //movementInput.y = Input.GetAxisRaw("Vertical");
        //movementInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementInput.normalized * speed;
        //Vector3 movement = new Vector3(movementInput.x, movementInput.y, 0f);
        //transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("¡Muerte!");
        }
            
    }

}
