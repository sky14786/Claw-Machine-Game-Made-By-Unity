using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteScripts : MonoBehaviour
{

    //void Update()
    //{
    //    if (SceneAdmin.Instance.SceneNum == 2)
    //    {

    //    }
    //    else
    //        GetComponent<AudioSource>().mute = true;
    //}

    public void FixedUpdate()
    {
        if (SoundManager.Instance.isMute)
            __Mute();
        else
            __UnMute();
    }

    public void __Mute()
    {
        GetComponent<Button>().onClick.AddListener(() => SoundManager.Instance._UnMute());
    }
    public void __UnMute()
    {
        GetComponent<Button>().onClick.AddListener(() => SoundManager.Instance._Mute());
    }
}