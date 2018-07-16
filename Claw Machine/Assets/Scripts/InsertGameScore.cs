using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertGameScore : MonoBehaviour {
    public string url;
    public int insert_score;
    public InputField nick_name;
    public GameObject Panel,RankPanel;
    public Text scoretxt;
	public bool isinsertRank;



    private void Awake()
    {
        url = "sky14786.cafe24.com/DB_Score_insert.php";
        insert_score = SceneController.instance.temp_score;
        scoretxt.text = ("Your Score : " + insert_score);
		isinsertRank = true;
    }

    public void PanelOn()
    {
		if(isinsertRank)
        Panel.active = true;
    }
	public void RankPanelOn()
	{
		RankPanel.active = true;
	}

	public void RankPanelOff()
	{
		RankPanel.active = false;
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

        form.AddField("nick_name", nick_name.text);
        form.AddField("score", insert_score);
        

        WWW webRequest = new WWW(url, form);
		
        yield return webRequest;

        Debug.Log(webRequest.error);
        yield break;
    }
}
