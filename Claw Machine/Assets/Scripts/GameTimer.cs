//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class GameTimer : MonoBehaviour
//{
//    public float Onesec;

//    private void Awake()
//    {
//        Onesec = 1f;
//    }


//    void Update()
//    {
//        if (GameManager.instance.GameTime >= 0)
//            PlayingTimeControl();
//        else
//        {
//            SceneManager.instance.temp_score = GameManager.instance.Score;
//            EndGameControl();
//        }

//    }

//    void PlayingTimeControl()
//    {
//        if (Onesec >= 0)
//        {
//            Onesec -= Time.deltaTime;
//        }
//        else
//        {
//            Onesec = 1f;
//            GameManager.instance.GameTime -= 1f;
//            GameManager.instance.GameTimer.value -= 1f;
//        }
//    }
//    void EndGameControl()
//    {
//        Debug.Log("게임끔");
//        SceneManager.instance.EndScene();
//    }
//}
