using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    public int coinScore = 0;

    public AudioClip scoreClip;
    private AudioSource audioSource;

    public GameObject WinPanel;

    void Start()
    {
        PlayerPrefs.SetInt("Coin", coinScore);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("Coin") == 34)
        {
            WinPanel.gameObject.SetActive(true);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            coinScore++;

            audioSource.PlayOneShot(scoreClip);
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("Coin", coinScore);
        }
    }
}
