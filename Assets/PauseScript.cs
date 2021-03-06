using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool isGamePaused = false;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject ComputerUI;
    [SerializeField] private GameObject EnterUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            ComputerUI.SetActive(false);
            EnterUI.SetActive(false);

            
            if (isGamePaused)
            {
                //resume
                resume();
            }
            else
            {
                //pause the game
                pause();
            }
        }
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        Cursor.visible = false;
    }

    void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void goMainMenu()
    {
        SceneManager.LoadScene("start");
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    

}
