using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   
    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
