using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class JsonRoadRank : MonoBehaviour {
    public GameObject RankPanel;
	public string url;
	public string[] oneuser, user_score, user_nick_name;
	public int i = 0;
	public GameObject[] TopTen;

	private void Awake()
	{
		url = "sky14786.cafe24.com/Json_Rank_Load.php";
	}
    public void RankPanelOn()
    {
        RankPanel.active = true;
        StartCoroutine(_LoadRank());
    }
    public void RankPanelOff()
    {
        RankPanel.active = false;
    }
	IEnumerator _LoadRank()
	{
		WWWForm form = new WWWForm();
		WWW WebRequest = new WWW(url);
		if (WebRequest.error == null)
			Debug.Log("error null");
		else
			Debug.Log("error");
		while (!WebRequest.isDone)
		{
			yield return null;
		}
		Debug.Log(WebRequest.text);
		var n = LitJson.JsonMapper.ToObject(WebRequest.text);
		Debug.Log(n.Count);
		for (i = 0; i < n.Count; i++)
		{
			TopTen[i].transform.GetChild(1).GetComponent<Text>().text= n[i]["nick_name"].ToString();
			TopTen[i].transform.GetChild(2).GetComponent<Text>().text = n[i]["score"].ToString();
		}
		yield return WebRequest;
	}
}
