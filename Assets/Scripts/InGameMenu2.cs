using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InGameMenu2 : MonoBehaviour 

{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("In_Game_Menu_Alpha_2");
        }
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ResumeGame()
    {
        SceneManager.LoadScene("Level_2_Alpha");
    }

    public void OptionsScene()
    {
        SceneManager.LoadScene("Options_Menu_Alpha_2");
    }

}
