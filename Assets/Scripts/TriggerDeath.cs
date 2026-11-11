using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("DeathScreen");
    }

}
