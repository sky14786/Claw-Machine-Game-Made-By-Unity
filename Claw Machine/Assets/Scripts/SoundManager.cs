using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource AudioObj;
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


   
    
    
}
