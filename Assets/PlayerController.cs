using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed = 5f;
    private CharacterController cc;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        cc.Move(move * movementSpeed * Time.deltaTime);

        //MoveDirection = orientation



        /* keep for maggie 
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
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, -movementSpeed);
        }*/
    }
}
