using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public bool isMute=false;
    public AudioSource AudioObj,Bg_Music;
    public AudioClip Make_Sound,Dead_Sound,Bg_Sound;

    public static SoundManager Instance
    {
        get
        {
            if(instance==null)
            {
                instance = new SoundManager();
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
   
    public void _MakeSound()
    {
        AudioObj.PlayOneShot(Make_Sound);
    }

    public void _DeadSound()
    {
        AudioObj.PlayOneShot(Dead_Sound);
    }
    public void _MuteManager()
    {
        if(isMute)
        {
            AudioObj.mute = false;
            Bg_Music.mute = false;
            isMute = false;
            UIManager.Instance._UISound(false);
            
        }
        else
        {
            AudioObj.mute = true;
            Bg_Music.mute = true;
            isMute = true;
            UIManager.Instance._UISound(true);
        }
    }
    public void _Mute()
    {
        AudioObj.mute = true;
        Bg_Music.mute = true;
        isMute = true;
        UIManager.Instance._UISound(true);
    }
    public void _UnMute()
    {
        AudioObj.mute = false;
        Bg_Music.mute = false;
        isMute = false;
        UIManager.Instance._UISound(false);
    }
    public void _MusicStart()
    {
        Bg_Music.Stop();
        Bg_Music.Play();
    }



   
    
    
}
