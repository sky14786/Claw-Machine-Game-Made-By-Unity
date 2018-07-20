using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdmin : MonoBehaviour
{
    private static SceneAdmin instance;
    public int SceneNum;

    public static SceneAdmin Instance
    {
        get
        {
            if(instance==null)
            {
                instance = new SceneAdmin();
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
        SceneNum = 1;
    }

    public void MainScene()
    {
        GameManager.Instance.ResetManager();
        SceneNum = 2;
        SceneManager.LoadScene("Main");
        SoundManager.Instance._UnMute();
        SoundManager.Instance._ResetMusic();
    }
    public void StartScene()
    {
        SceneNum = 1;
        SceneManager.LoadScene("StartScene");
    }
    public void EndScene()
    {
        SceneNum = 3;
        SceneManager.LoadScene("EndScene");
        Destroy(UIManager.Instance.gameObject);
        SoundManager.Instance._Mute();

    }
}
