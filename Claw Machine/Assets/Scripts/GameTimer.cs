using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float Onesec;

    // Use this for initialization
    private void Awake()
    {
        //Debug.Log("Game Time Setting Success!");
        //GameManager.instance.GameTimer.value = 10f;
        //GameManager.instance.GameTime = 10f;
        //UIManager.instance.ScoreText.text = "Score : 0";
        Onesec = 1f;
    }


    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GameTime >= 0)
            PlayingTimeControl();
        else
        {
            SceneController.instance.temp_score = GameManager.instance.Score;
            EndGameControl();
        }
        
    }

    void PlayingTimeControl()
    {
        if (Onesec >= 0)
        {
            Onesec -= Time.deltaTime;
        }
        else
        {
            //Debug.Log("1");
            Onesec = 1f;
            GameManager.instance.GameTime -= 1f;
            GameManager.instance.GameTimer.value -= 1f;
            //Debug.Log(GameManager.instance.GameTimer);
        }
    }
    void EndGameControl()
    {
            Debug.Log("게임끔");
        //GameManager.instance.Insertscore();
        SceneController.instance.EndScene();
    }
}
