using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenuScript : MonoBehaviour
{

    public void StartFromEntrance()
    {
        SceneManager.LoadScene("sliitEnvironment");
    }

    public void StartFromLibrary()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EndApp()
    {
        Application.Quit();
    }

    public void replayApp()
    {
        SceneManager.LoadScene("sliitEnvironment");
    }

    public void quitApp()
    {
        Application.Quit();
    }
}
