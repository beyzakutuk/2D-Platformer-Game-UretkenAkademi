using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource musicSource;
    private bool isMusicPlaying = true;

    public GameObject x;

    private void Start()
    {
        musicSource = GetComponent<AudioSource>();
        // Müziği başlangıçta çalabilirsiniz
        musicSource.Play();
    }

    public void ToggleMusic()
    {
        // Müziği durdur veya başlat
        if (isMusicPlaying)
        {
            musicSource.Pause();
            x.gameObject.SetActive(true);
        }
        else
        {
            musicSource.UnPause();
            x.gameObject.SetActive(false);
        }

        // Durum değişikliğini güncelle
        isMusicPlaying = !isMusicPlaying;
    }
}
