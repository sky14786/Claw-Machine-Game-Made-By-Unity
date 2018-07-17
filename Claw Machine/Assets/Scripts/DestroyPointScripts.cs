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
            EffectManager.instance._EfOn(1);
            GameManager.instance.ddolsCount--;
            SoundManager.instance._DeadSound();
            
        }

        if (collision.tag == "item")
        {
            switch (collision.gameObject.name)
            {//  angle = (angle > 180) ? angle - 360 : angle;
                case "item1(Clone)":
                    if (GameManager.instance.isMulScore)
                        GameManager.instance.MulTime += 3;
                    else
                    {
                        GameManager.instance.ScoreMul = 2;
                        StartCoroutine(GameManager.instance.MulScore());
                    }
                    break;
                case "item2(Clone)":
                    if (GameManager.instance.isMulScore)
                    {
                        if (GameManager.instance.ScoreMul < 3)
                        {
                            GameManager.instance.ScoreMul = 3;
                            StartCoroutine(GameManager.instance.MulScore());
                        }
                        else
                            GameManager.instance.MulTime += 3;
                    }
                    else
                    {
                        GameManager.instance.ScoreMul = 3;
                        StartCoroutine(GameManager.instance.MulScore());
                    }
                    break;
                case "item3(Clone)":
                    if (UIManager.instance.GameTimer.value <= UIManager.instance.GameTimer.maxValue)
                    {
                        if (GameManager.instance.GameTime <= UIManager.instance.GameTimer.maxValue)
                        {
                            GameManager.instance.GameTime = +3f;
                            UIManager.instance.GameTimer.value += 3f;
                            Debug.Log(UIManager.instance.GameTimer.value);
                        }
                    }
                    break;
                case "item4(Clone)":
                    GameManager.instance.PowerTime = +5f;
                    break;
            }
            Destroy(collision.gameObject);
            EffectManager.instance._EfOn(2);
            GameManager.instance.itemddolsCount--;
            SoundManager.instance._DeadSound();
            //Destroy(Effect);

        }
    }
}

