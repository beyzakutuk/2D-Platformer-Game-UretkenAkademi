using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryOnClick()
    {
        SceneManager.LoadScene(2);
    }

    public void exitGameButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void nextGameButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
