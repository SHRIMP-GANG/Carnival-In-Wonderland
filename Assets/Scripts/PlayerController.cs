using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed = 3.5f;
    private CharacterController cc;
<<<<<<< HEAD:Assets/PlayerController.cs


=======
    private Camera cam;
    
>>>>>>> 82d57bc654aafacf658a2f317995e9d0c937e225:Assets/Scripts/PlayerController.cs
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Assets/PlayerController.cs
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
=======
        float cameraYRotation = Camera.main.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, cameraYRotation, 0);
        Vector3 move = transform.right*Input.GetAxis("Horizontal") + transform.forward*Input.GetAxis("Vertical");
>>>>>>> 82d57bc654aafacf658a2f317995e9d0c937e225:Assets/Scripts/PlayerController.cs
        cc.Move(move * movementSpeed * Time.deltaTime);

        //MoveDirection = orientation



        /*if (Input.GetKey(KeyCode.W))
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
