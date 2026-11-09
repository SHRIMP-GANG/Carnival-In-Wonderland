using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public float movementSpeed = 5.0f;
    private CharacterController cc;
    [SerializeField] public float stamina = 1f;
    public bool sprinting;


    private Camera cam;
    private Headbob hb;

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

        if (sprinting == true)
        {

            movementSpeed = 5.5f;
        }
        else
        {

            if (stamina < 1.0f)
            {

                stamina += Time.deltaTime / 36f;
            }

        }

        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        float cameraYRotation = Camera.main.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, cameraYRotation, 0);
        cc.Move(move * movementSpeed * Time.deltaTime);

        if ((Input.GetKey(KeyCode.LeftShift) && stamina > 0.01f) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {

            sprinting = true;

            stamina -= Time.deltaTime / 6f;

        }
        else
        {

            sprinting = false;

        }

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
