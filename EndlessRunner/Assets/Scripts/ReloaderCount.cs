using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReloaderCount : MonoBehaviour
{
    private static ReloaderCount reloaderCount;
    public GameObject MenuPanel;
    public GameObject ScorText;
    public GameObject HighScorText;
    public GameObject HighScorText2;
    public GameObject Spawner;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public TMP_Text HscoreText;
    public TMP_Text HscoreText2;
    
    void Awake()
    {
        if (reloaderCount == null)
        {
            reloaderCount = this;
            DontDestroyOnLoad(reloaderCount);

        }
        else
        {
            Destroy(gameObject);
        }

    }
    private int reloadc = 0;
    void Start()
    {
        reloadc += 1;
        if (reloadc == 1 )
        {
            MenuPanel.SetActive(true);
            ScorText.SetActive(false);
            HighScorText.SetActive(true);
            HighScorText2.SetActive(false);
            HscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            Spawner.SetActive(false);
            Spawner2.SetActive(false);
            Spawner3.SetActive(false);
        }
        else
        {
            MenuPanel.SetActive(false);
            ScorText.SetActive(true);
            HighScorText.SetActive(false);
            HighScorText2.SetActive(false);
            HscoreText2.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            Spawner.SetActive(true);
            Spawner2.SetActive(true);
            Spawner3.SetActive(true);
        }
    }
}
