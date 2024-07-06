using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;

    public void OpenMenu()
    {
        if(Menu != null)
        {
            bool isActive = Menu.activeSelf;
            Menu.SetActive(!isActive);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
