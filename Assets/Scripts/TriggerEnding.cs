using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnding : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("is this even happening");

        SceneManager.LoadScene("Ending");
    }
}
