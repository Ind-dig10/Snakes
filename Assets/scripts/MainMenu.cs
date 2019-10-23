using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void OnClickExit()
    {
        Application.Quit();
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
