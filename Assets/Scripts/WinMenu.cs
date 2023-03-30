using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void Menu()
   {
        SceneManager.LoadScene("Menu");
   }
    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
