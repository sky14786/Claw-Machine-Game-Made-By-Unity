using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertGameScore : MonoBehaviour {
    public string url;
    public InputField nick_name;
    public GameObject Panel;
    public Text scoretxt;
	public bool isinsertRank;

    private void Awake()
    {
        url = "sky14786.cafe24.com/DB_Score_insert.php";
        //insert_score = SceneAdmin.instance.temp_score;
        scoretxt.text = ("Your Score : " + GameManager.instance.Score.ToString());
		isinsertRank = true;
        Panel.active = false;
        nick_name.text ="Insert Your Nick_name";
    }

    public void PanelOn()
    {
		if(isinsertRank)
        Panel.active = true;
    }
    public void Insertscore()
    {
       
        Debug.Log("점수넣기");
        StartCoroutine(_InsertScore());
        Panel.active = false;
		isinsertRank = false;
    }
    IEnumerator _InsertScore()
    {
        Debug.Log("Start");
        WWWForm form = new WWWForm();
        if (nick_name.text == "Insert Your Nick_name")
           nick_name.text = "Human"+Random.Range(1,99).ToString();

        form.AddField("nick_name", nick_name.text);
        form.AddField("score", GameManager.instance.Score);
        

        WWW webRequest = new WWW(url, form);
		
        yield return webRequest;

        Debug.Log(webRequest.error);
        yield break;
    }
}
