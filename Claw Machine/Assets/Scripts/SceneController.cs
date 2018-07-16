using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //public Scene Start = SceneManager.GetSceneByName("StartScene").isLoaded
    //public Scene Main = SceneManager.GetSceneByName("MainScene");
    //public Scene End = SceneManager.GetSceneByName("EndScene");
    public static SceneController instance;
    public int temp_score;
    public int SceneNum;
	public AudioClip bgmClip;
	public AudioSource bgmSource;
   

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

    public void MainScene()
    {

        SceneNum = 2;
        //Destroy(GameManager.instance.gameObject);
        //GameManager.instance.GameTimer = 5f;
        SceneManager.LoadScene("Main");

    }
    public void StartScene()
    {
        SceneNum = 1;
        SceneManager.LoadScene("StartScene");
        //Destroy(UIManager.instance.gameObject);
    }
    public void EndScene()
    {
        //temp_score = UIManager.instance.score
        SceneNum = 3;
        SceneManager.LoadScene("EndScene");
        Destroy(UIManager.instance.gameObject);
        Destroy(GameManager.instance.gameObject);
        Destroy(gameObject);

    }
}
