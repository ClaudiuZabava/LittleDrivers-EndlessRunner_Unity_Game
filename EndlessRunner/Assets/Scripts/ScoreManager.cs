using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text HscoreText;
    public TMP_Text HscoreText2;
    private double score;
    private int hscore=0;
    
    void Start()
    {
        hscore = PlayerPrefs.GetInt("HighScore", 0);
        HscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        HscoreText2.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null )
        {
            score += 2.0f * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            if(score > hscore)
            {
                hscore = (int)score;
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", hscore);
            HscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            HscoreText2.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }
}
