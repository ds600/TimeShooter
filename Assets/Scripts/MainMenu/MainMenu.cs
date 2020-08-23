using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level0");
    }

    public void ExitGame()
    {
        Application.Quit();
    }



}
