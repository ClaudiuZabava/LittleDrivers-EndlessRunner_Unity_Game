using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image SoundOnInc;
    [SerializeField] Image SoundOffInc;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.volume = 1.0f;
            SoundOnInc.enabled = true;
            SoundOffInc.enabled = false;
        }
        else
        {
            muted = false;
            AudioListener.volume = 0.0f;
            SoundOnInc.enabled = false;
            SoundOffInc.enabled = true;
        }
        Save();
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
        if (muted == false)
        {
            AudioListener.volume = 0.0f;
            SoundOnInc.enabled = false;
            SoundOffInc.enabled = true;
        }
        else
        {
            AudioListener.volume = 1.0f;
            SoundOnInc.enabled = true;
            SoundOffInc.enabled = false;
        }

    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
