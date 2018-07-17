using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdmin : MonoBehaviour
{
    public static SceneAdmin instance;
    public int SceneNum;

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
        Destroy(UIManager.instance.gameObject);
        Destroy(GameManager.instance.gameObject);
    }
}
