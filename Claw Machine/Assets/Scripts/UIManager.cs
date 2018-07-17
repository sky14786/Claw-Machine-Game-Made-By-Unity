using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text ScoreText, MulText;
	public GameObject DeadEffect, RankPanel, InsertScorePanel;
    public Slider GameTimer;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        ScoreText.text = "SCORE : 0";
    }
    public void Update()
    {
       ScoreText.text = "Score : " + GameManager.instance.Score.ToString();
    }
}
