using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InGameMenu1 : MonoBehaviour 

{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("In_Game_Menu_Alpha_1");
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level_Alpha");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ResumeGame()
    {
        SceneManager.LoadScene("Menu_Alpha");
    }

    public void OptionsScene()
    {
        SceneManager.LoadScene("Options_Menu_Alpha_1");
    }

}
