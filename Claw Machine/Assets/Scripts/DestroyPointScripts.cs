using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyPointScripts : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ddols")
        {
            switch (collision.gameObject.name)
            {
                case "ddols1(Clone)":
                    GameManager.Instance.Score = GameManager.Instance.Score + (GameManager.Instance.ScoreMul * 1);
                    break;
                case "ddols2(Clone)":
                    GameManager.Instance.Score = GameManager.Instance.Score + (GameManager.Instance.ScoreMul * 2);
                    break;
                case "ddols3(Clone)":
                    GameManager.Instance.Score = GameManager.Instance.Score + (GameManager.Instance.ScoreMul * 3);
                    break;
                case "ddols4(Clone)":
                    GameManager.Instance.Score = GameManager.Instance.Score + (GameManager.Instance.ScoreMul * 4);
                    break;
                case "ddols5(Clone)":
                    GameManager.Instance.Score = GameManager.Instance.Score + (GameManager.Instance.ScoreMul * 5);
                    break;
            }
            Destroy(collision.gameObject);
            EffectMaker.Instance.MakeOfEffect(1);
            GameManager.Instance.ddolsCount--;
            SoundManager.Instance._DeadSound();
            
        }

        if (collision.tag == "item")
        {
            switch (collision.gameObject.name)
            {//  angle = (angle > 180) ? angle - 360 : angle;
                case "item1(Clone)":
                    if (GameManager.Instance.isMulScore)
                        GameManager.Instance.MulTime += 3;
                    else
                    {
                        GameManager.Instance.ScoreMul = 2;
                        StartCoroutine(GameManager.Instance.MulScore());
                    }
                    break;
                case "item2(Clone)":
                    if (GameManager.Instance.isMulScore)
                    {
                        if (GameManager.Instance.ScoreMul < 3)
                        {
                            GameManager.Instance.ScoreMul = 3;
                            StartCoroutine(GameManager.Instance.MulScore());
                        }
                        else
                            GameManager.Instance.MulTime += 3;
                    }
                    else
                    {
                        GameManager.Instance.ScoreMul = 3;
                        StartCoroutine(GameManager.Instance.MulScore());
                    }
                    break;
                case "item3(Clone)":
                    if (UIManager.Instance.GameTimer.value <= UIManager.Instance.GameTimer.maxValue)
                    {
                        if (GameManager.Instance.GameTime <= UIManager.Instance.GameTimer.maxValue)
                        {
                            GameManager.Instance.GameTime = +3f;
                            UIManager.Instance.GameTimer.value += 3f;
                            Debug.Log(UIManager.Instance.GameTimer.value);
                        }
                    }
                    break;
                case "item4(Clone)":
                    GameManager.Instance.PowerTime = +5f;
                    break;
            }
            Destroy(collision.gameObject);
            EffectMaker.Instance.MakeOfEffect(2);
            GameManager.Instance.itemddolsCount--;
            SoundManager.Instance._DeadSound();
            //Destroy(Effect);

        }
    }
}

