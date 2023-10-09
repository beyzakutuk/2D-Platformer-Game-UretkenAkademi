using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text Coin;
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;

    void Start()
    {
        
    }
    void Update()
    {
        Coin.text = PlayerPrefs.GetInt("Coin") + "";

        if(PlayerPrefs.GetInt("Heart") == 2)
        {
            Heart3.gameObject.SetActive(false);
        }

        if(PlayerPrefs.GetInt("Heart") == 1)
        {
            Heart3.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(false);
        }

        if(PlayerPrefs.GetInt("Heart") == 0)
        {
            Heart3.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(false);
            Heart1.gameObject.SetActive(false);
        }
    }
}
