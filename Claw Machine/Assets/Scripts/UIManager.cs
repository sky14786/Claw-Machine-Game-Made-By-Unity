using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  
    public static UIManager instance;
    public Text ScoreText;
    public Text MulText;
	public GameObject DeadEffect;
	
   
    
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //else
        //{
        //    Destroy(gameObject);
        //}
        ScoreText.text = "SCORE : 0";
    }

    

    public void StartScene()
    {
        SceneController.instance.StartScene();
    }
    
    public void MainScene()
    {
        SceneController.instance.MainScene();
    }

    public void EndScene()
    {
        SceneController.instance.EndScene();
    }
    

}
