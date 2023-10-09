using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSettings : MonoBehaviour
{
    public GameObject LevelPanel;

    public void playOnClick()
    {
        LevelPanel.gameObject.SetActive(true);
    }

    public void backOnClick()
    {
        LevelPanel.gameObject.SetActive(false);
    }

    public void quitOnClick()
    {
        Application.Quit();
    }

    public void Level1OnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGameButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
