using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            //unpause
            Time.timeScale = 1.0f;

            pauseUI.SetActive(false);

            isPaused = false;
        }
        else
        {
            //pause
            Time.timeScale = 0.0f;

            pauseUI.SetActive(true);

            isPaused = true;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}