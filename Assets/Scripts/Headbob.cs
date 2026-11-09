using UnityEngine;

public class Headbob : MonoBehaviour
{

    public Animator camAnim;
    public PlayerController player;
    private bool walking;
    public string currentState;

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            camAnim.ResetTrigger("idle");
            walking = true;
            camAnim.ResetTrigger("sprint");
            camAnim.SetTrigger("walk");

            currentState = "walk";
            // Debug.Log("walking");

            if (walking)
            {

                if (Input.GetKey(KeyCode.LeftShift) && player.stamina > 0.01f)
                {

                    camAnim.ResetTrigger("walk");
                    camAnim.ResetTrigger("idle");
                    camAnim.SetTrigger("sprint");

                    currentState = "sprint";

                }
            }

        }
        else
        {

            camAnim.ResetTrigger("sprint");
            camAnim.ResetTrigger("walk");
            camAnim.SetTrigger("idle");

            currentState = "idle";
            // Debug.Log("idling");

        }
    }
}
