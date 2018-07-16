using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager instance;

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
        Debug.Log("Game Time Setting Success!");
        //url = "sky14786.cafe24.com/DB_Score_insert.php";
        GameTimer.value = 10f;
        GameTime = 10f;
        //UIManager.instance.ScoreText.text = "Score : 0";
    }
    //public GameObject dead;
    public float MoveSpeed;
    public int ddolsCount = 0;
    public int itemddolsCount = 0;
    public int ScoreMul;
    public int Score = 0;
    public float MulTime;
    public bool isMulScore;
    public Slider GameTimer;
    public float PowerTime;
    public float GameTime;


    //public string url;
    //public float GameTimer;


    

    public IEnumerator MulScore()
    {
        isMulScore = true;
        MulTime += 5f;
        UIManager.instance.MulText.text = "X" +ScoreMul;
        while (true)
        {
            yield return new WaitForSecondsRealtime(Time.deltaTime);
            MulTime -= Time.deltaTime;
            if (MulTime <= 0f)
            {
                UIManager.instance.MulText.text = "X1";
                isMulScore = false;
                ScoreMul = 1;
                break;
            }
        }
    }

    //public void Insertscore()
    //{
    //    Debug.Log("점수넣기");
    //    StartCoroutine(_InsertScore());
    //}



    //IEnumerator _InsertScore()
    //{
    //    Debug.Log("Start");
    //    WWWForm form = new WWWForm();
    //    //form.AddField("nick_name",)
    //    form.AddField("score", Score);
    //    //form.AddField("nick_name", "test");

    //    WWW webRequest = new WWW(url, form);
    //    yield return webRequest;

    //    Debug.Log(webRequest.error);
    //    yield break;
    //}
}