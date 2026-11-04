using UnityEngine;

public class Headbob : MonoBehaviour
{

    public Animator camAnim;
    public bool walking;

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            camAnim.ResetTrigger("idle");
            walking = true;
            camAnim.ResetTrigger("sprint");
            camAnim.SetTrigger("walk");
            // Debug.Log("walking");

            if (walking)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {

                    camAnim.ResetTrigger("walk");
                    camAnim.ResetTrigger("idle");
                    camAnim.SetTrigger("sprint");

                }
            }

        }
        else
        {

            camAnim.ResetTrigger("sprint");
            camAnim.ResetTrigger("walk");
            camAnim.SetTrigger("idle");
            // Debug.Log("idling");

        }
    }
}
