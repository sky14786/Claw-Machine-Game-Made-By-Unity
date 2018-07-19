using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject EffectPoint;
    public float MoveSpeed, PowerTime, GameTime, MulTime, Onesec=1;
    public int ddolsCount = 0, itemddolsCount =0, ScoreMul=1, Score=0;
    public bool isMulScore;

    public static GameManager Instance
    {
        get
        {
            if(instance==null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    
    public void ResetManager()
    {
        PowerTime = 0;
        GameTime = 15;
        MulTime = 0;
        Onesec = 1;
        ddolsCount = 0;
        itemddolsCount = 0;
        ScoreMul = 1;
        Score = 0;
        MoveSpeed = 0.1f;
    }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("Game Manager Call Success !");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        if (SceneAdmin.Instance.SceneNum == 2)
        {
            if (GameTime >= 0)
                PlayingTimeControl();
            else
            {
                //SceneAdmin.instance.temp_score = Score;
                EndGameControl();
            }
        }
    }

    public void Start()
    {
        Debug.Log("Game Time Setting Success!");
        GameTime = 15f;
        UIManager.Instance.GameTimer.value = 15f;
        ScoreMul = 1;
    }
    void PlayingTimeControl()
    {
        if (Onesec >= 0)
        {
            Onesec -= Time.deltaTime;
        }
        else
        {
            Onesec = 1f;
            GameTime -= 1f;
            UIManager.Instance.GameTimer.value -= 1f;
        }
    }
    void EndGameControl()
    {
        Debug.Log("게임끔");
        SceneAdmin.Instance.EndScene();
    }









    public IEnumerator MulScore()
    {
        isMulScore = true;
        MulTime += 5f;
        UIManager.Instance.MulText.text = "X" + ScoreMul;
        while (true)
        {
            yield return new WaitForSecondsRealtime(Time.deltaTime);
            MulTime -= Time.deltaTime;
            if (MulTime <= 0f)
            {
                UIManager.Instance.MulText.text = "X1";
                isMulScore = false;
                ScoreMul = 1;
                break;
            }
        }
    }
}