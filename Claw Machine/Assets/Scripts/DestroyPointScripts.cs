using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyPointScripts : MonoBehaviour
{
	public AudioSource DeadSource;
	public AudioClip DeadSound;
    //public enum ItemType
    //{
    //    a,
    //    b,
    //    c,
    //    d = 100,
    //    e
    //}

    //public ItemType type;


    // Use this for initialization
    void Start()
    {
        GameManager.instance.ScoreMul = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ddols")
        {
            switch (collision.gameObject.name)
            {
                case "ddols1(Clone)":
                    GameManager.instance.Score = GameManager.instance.Score + (GameManager.instance.ScoreMul * 1);
                    break;
                case "ddols2(Clone)":
                    GameManager.instance.Score = GameManager.instance.Score + (GameManager.instance.ScoreMul * 2);
                    break;
                case "ddols3(Clone)":
                    GameManager.instance.Score = GameManager.instance.Score + (GameManager.instance.ScoreMul * 3);
                    break;
                case "ddols4(Clone)":
                    GameManager.instance.Score = GameManager.instance.Score + (GameManager.instance.ScoreMul * 4);
                    break;
                case "ddols5(Clone)":
                    GameManager.instance.Score = GameManager.instance.Score + (GameManager.instance.ScoreMul * 5);
                    break;
            }
            Destroy(collision.gameObject);
            UIManager.instance.DeadEffect = Instantiate(Resources.Load("Hearts_02") as GameObject);
            UIManager.instance.DeadEffect.transform.position = gameObject.transform.position;

            //GameObject Deadeffect = Instantiate(Resources.Load("Hearts_02")as GameObject);
            //Deadeffect.transform.position = gameObject.transform.position;
            GameManager.instance.ddolsCount--;
            UIManager.instance.ScoreText.text = "Score : " + GameManager.instance.Score.ToString();
			DeadSource.PlayOneShot(DeadSound);
        }

        if (collision.tag == "item")
        {
            switch (collision.gameObject.name)
            {//  angle = (angle > 180) ? angle - 360 : angle;
                case "item1(Clone)":
                    if (GameManager.instance.isMulScore)
                    {
                        //Debug.Log(GameManager.instance.isMulScore);
                        GameManager.instance.MulTime += 3;
                    }
                    else
                    {
                        //Debug.Log("2");
                        GameManager.instance.ScoreMul = 2;
                        StartCoroutine(GameManager.instance.MulScore());
                    }
                    break;
                //MulScore(2);

                case "item2(Clone)":
                    if (GameManager.instance.isMulScore)
                    {
                        if (GameManager.instance.ScoreMul < 3)
                        {
                            GameManager.instance.ScoreMul = 3;
                            StartCoroutine(GameManager.instance.MulScore());
                        }
                        else
                        {
                            GameManager.instance.MulTime += 3;
                        }
                    }
                    else
                    {
                        GameManager.instance.ScoreMul = 3;
                        StartCoroutine(GameManager.instance.MulScore());
                    }
                    break;
                case "item3(Clone)":
                    if (GameManager.instance.GameTimer.value <= GameManager.instance.GameTimer.maxValue)
                    {
                        if (GameManager.instance.GameTime <= GameManager.instance.GameTimer.maxValue)
                        {
                            GameManager.instance.GameTime = +3f;
                            GameManager.instance.GameTimer.value += 3f;
                            Debug.Log(GameManager.instance.GameTimer.value);
                        }
                    }
                    break;
                case "item4(Clone)":
                    GameManager.instance.PowerTime = +5f;
                    break;

            }
            Destroy(collision.gameObject);
            UIManager.instance.DeadEffect = Instantiate(Resources.Load("Fx_OilSplashHIGH_Root") as GameObject);
            UIManager.instance.DeadEffect.transform.position = gameObject.transform.position;
            GameManager.instance.itemddolsCount--;
			DeadSource.PlayOneShot(DeadSound);
		}
    }
}

