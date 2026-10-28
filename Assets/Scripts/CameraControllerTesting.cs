using UnityEngine;

public class CameraControllerTesting : MonoBehaviour
{

    public float sens = 2f;
    private float xRotation = 0f;
    private float yRotation = 0f;
    


    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * sens;
        float mouseY = Input.GetAxis("Mouse Y") * sens;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        yRotation += mouseX;
        

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        //transform.parent.Rotate(Vector3.up * mouseX);

    }
}
