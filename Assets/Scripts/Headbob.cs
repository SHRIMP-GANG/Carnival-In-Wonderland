using UnityEngine;

public class Headbob : MonoBehaviour
{

    public Animator camAnim;
    public PlayerController player;
    private bool walking;
    public enum BobState { IDLE, WALK, SPRINT };
    public string currentStateStr;
    public BobState currentState = BobState.IDLE;

    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            camAnim.ResetTrigger("idle");
            walking = true;
            camAnim.ResetTrigger("sprint");
            camAnim.SetTrigger("walk");

            currentState = BobState.WALK;
            // Debug.Log("walking");

            if (walking)
            {

                if (Input.GetKey(KeyCode.LeftShift) && player.stamina > 0.01f)
                {

                    camAnim.ResetTrigger("walk");
                    camAnim.ResetTrigger("idle");
                    camAnim.SetTrigger("sprint");

                    currentState = BobState.SPRINT;

                }
            }

        }
        else
        {

            camAnim.ResetTrigger("sprint");
            camAnim.ResetTrigger("walk");
            camAnim.SetTrigger("idle");

            currentState = BobState.IDLE;
            // Debug.Log("idling");

        }

        currentStateStr = currentState.ToString();
    }
}
