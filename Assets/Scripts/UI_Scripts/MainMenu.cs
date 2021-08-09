using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioSource source;


    public void ChangeScene(int sceneIndex)
    {
        source.Play();
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        source.Play();
        Application.Quit();
    }


}
