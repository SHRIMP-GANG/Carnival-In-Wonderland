using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float lerp=10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPos=new Vector3(target.transform.position.x,transform.position.y,-5);
        
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*lerp);
    }
}
