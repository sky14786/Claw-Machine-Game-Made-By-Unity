using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class JsonRoadRank : MonoBehaviour {

	public string url;
	public string[] oneuser, user_score, user_nick_name;
	public int i = 0;
	public GameObject[] TopTen;
	//public Text Rank, Nick_Name, Score;
	



	private void Awake()
	{
		url = "sky14786.cafe24.com/Json_Rank_Load.php";
		StartCoroutine(_LoadRank());
	}

	//public void LoadRank()
	//{
	//	StartCoroutine(_LoadRank());
	//}

	IEnumerator _LoadRank()
	{
		WWWForm form = new WWWForm();
		//Debug.Log("0");
		WWW WebRequest = new WWW(url);
		//Debug.Log("1");
		if (WebRequest.error == null)
			Debug.Log("error null");
		else
			Debug.Log("error");
		//Debug.Log("2");
		while (!WebRequest.isDone)
		{
			//Debug.Log("Download");
			yield return null;
		}
		Debug.Log(WebRequest.text);

		var n = LitJson.JsonMapper.ToObject(WebRequest.text);
		Debug.Log(n.Count);
		for (i = 0; i < n.Count; i++)
		{
			//TopTen[i].transform.FindChild("Nick_Name").GetComponent<Text>().text = n[i]["nick_name"].ToString();
			//TopTen[i].transform.FindChild("Score").GetComponent<Text>().text = n[i]["score"].ToString();
			TopTen[i].transform.GetChild(1).GetComponent<Text>().text= n[i]["nick_name"].ToString();
			TopTen[i].transform.GetChild(2).GetComponent<Text>().text = n[i]["score"].ToString();

			//Debug.Log(n[i]["nick_name"].ToString() + " : " + n[i]["score"].ToString());
		}

		

		yield return WebRequest;
	}
}
