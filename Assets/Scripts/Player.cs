using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movementSpeed = 5f;
    public float jumpForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(transform.position.y=)
        
        if (Input.GetKey(KeyCode.A))
            rb.linearVelocity = new Vector2(-movementSpeed, rb.linearVelocity.y);
        
        if (Input.GetKey(KeyCode.D))
            rb.linearVelocity = new Vector2(movementSpeed, rb.linearVelocity.y);
        if(Input.GetKeyDown(KeyCode.W))
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
}
