using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector3(movementSpeed, rb.linearVelocity.y,rb.linearVelocity.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector3(-movementSpeed, rb.linearVelocity.y,rb.linearVelocity.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, movementSpeed,rb.linearVelocity.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, -movementSpeed,rb.linearVelocity.z);
        }
    }
}
