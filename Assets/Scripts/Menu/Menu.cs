using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OpenMenu(GameObject menu)
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseMenu(GameObject menu)
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenAuthorsMenu(GameObject authorsMenu)
    {
        authorsMenu.SetActive(true);
    }

    public void CloseAuthorsMenu(GameObject authorsMenu)
    {
        authorsMenu.SetActive(false);
    }
}
