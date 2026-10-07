using System;
using UnityEngine;

public class SceneMenuTransition : MonoBehaviour
{
    public static void ChangeScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}


