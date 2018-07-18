using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdmin : MonoBehaviour
{
    private static SceneAdmin instance;

    public static SceneAdmin Instance
    {
        get
        {
            if(instance ==null)
            {
                instance = new SceneAdmin();
            }
            return instance;
        }
    }
    public int SceneNum;

    private void Awake()
    {
        if (instance == null)
        {
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
        SceneNum = 2;
        SceneManager.LoadScene("Main");
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
        Destroy(GameManager.Instance.gameObject);
    }
}
