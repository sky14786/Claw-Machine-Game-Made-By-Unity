using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public bool isMute=false;
    public AudioSource AudioObj,Bg_Music;
    public AudioClip Make_Sound,Dead_Sound;

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
            UIManager.instance._UISound(false);
            
        }
        else
        {
            AudioObj.mute = true;
            Bg_Music.mute = true;
            isMute = true;
            UIManager.instance._UISound(true);
        }
    }



   
    
    
}
