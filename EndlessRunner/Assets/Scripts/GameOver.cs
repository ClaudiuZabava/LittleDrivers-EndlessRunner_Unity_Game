using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject player1;
    public GameObject gameOverPanel;
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public GameObject ScorText;
    public GameObject Spawner;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject HighScorText;
    public GameObject HighScorText2;

    private int check;

    // Update is called once per frame
    void Update()
    {
        if ( GameObject.FindGameObjectWithTag("Player") == null)
        {
            this.check=1;
            gameOverPanel.SetActive(true);
            HighScorText2.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);


    }
    // vezi la obiectul "Reloader". In Start, MenuPanel e activ. Dupa play, la retry ramane inactiv.
    public void Play()
    {
        MenuPanel.SetActive(false);
        ScorText.SetActive(true);
        HighScorText.SetActive(false);
        HighScorText2.SetActive(false);
        Spawner.SetActive(true);
        Spawner2.SetActive(true);
        Spawner3.SetActive(true);
    }

    public void Settings()
    {
        OptionsPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        MenuPanel.SetActive(false);
        ScorText.SetActive(false);
        HighScorText.SetActive(false);
        HighScorText2.SetActive(false);
        Spawner.SetActive(false);
        Spawner2.SetActive(false);
        Spawner3.SetActive(false);
    }
    public void SettingsBack()
    {
        OptionsPanel.SetActive(false);
        if(this.check == 1)
        {
            gameOverPanel.SetActive(true);
            MenuPanel.SetActive(false);
            ScorText.SetActive(true);
            HighScorText2.SetActive(true);

        }
        else
        {
            gameOverPanel.SetActive(false);
            MenuPanel.SetActive(true);
            ScorText.SetActive(false);
            HighScorText.SetActive(true);
        }
        Spawner.SetActive(false);
        Spawner2.SetActive(false);
        Spawner3.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
