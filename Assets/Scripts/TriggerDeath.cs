using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("DeathScreen");
    }

}
