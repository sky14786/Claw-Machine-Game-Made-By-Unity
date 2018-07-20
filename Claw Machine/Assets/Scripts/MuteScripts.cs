using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteScripts : MonoBehaviour
{
    public void Update()
    {
        if (!SoundManager.Instance.isMute)
            __Mute();
        else
            __UnMute();
    }

    public void __Mute()
    {
        GetComponent<Button>().onClick.AddListener(() => SoundManager.Instance._Mute());
    }
    public void __UnMute()
    {
        GetComponent<Button>().onClick.AddListener(() => SoundManager.Instance._UnMute());
    }
}
