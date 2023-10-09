using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Buttons : MonoBehaviour
{
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void RetryOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGameButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void nextGameButtonOnClick()
    {
        SceneManager.LoadScene(2);
    }
}
