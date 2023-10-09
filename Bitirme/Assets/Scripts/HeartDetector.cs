using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartDetector : MonoBehaviour
{
    public int heartCount=3;
    private Vector3 initialPosition;

    private bool _continue = true;
    private bool hasTouchedSea = false;
    private bool hasTouchedDiken = false;

    public GameObject tryAgainPanel;

    void Start()
    {
        PlayerPrefs.SetInt("Heart", heartCount);

        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(heartCount <= 0)
        {
            _continue = false;
            tryAgainPanel.gameObject.SetActive(true);
        }

        if(!_continue)
        {
            tryAgainPanel.gameObject.SetActive(true);
        }

        if(hasTouchedSea && transform.position == initialPosition)
        {
            hasTouchedSea = false;
        }

        if (hasTouchedDiken && transform.position == initialPosition)
        {
            hasTouchedDiken = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Sea"))
        {
            if (!hasTouchedSea)
            {
                transform.position = initialPosition;
                heartCount--;
                PlayerPrefs.SetInt("Heart", heartCount);
                hasTouchedSea = true;
            }

        }

        if(collision.gameObject.CompareTag("diken"))
        {
            if (!hasTouchedDiken)
            {
                transform.position = initialPosition;
                heartCount--;
                PlayerPrefs.SetInt("Heart", heartCount);
                hasTouchedDiken = true;
            }
        }
    }
}
