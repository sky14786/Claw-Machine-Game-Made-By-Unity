using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadGameRank : MonoBehaviour {
    public string url;
	public string[] oneuser,user_score,user_nick_name;
	public int i,j=0;
	
	

    private void Awake()
    {
        url = "sky14786.cafe24.com/DB_Rank_Load.php";

    }

	public void LoadRank()
	{
		StartCoroutine(_LoadRank());
	}

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
		oneuser = WebRequest.text.Split('#');
		user_nick_name = new string[oneuser.Length/2];
		user_score = new string[oneuser.Length / 2];

		Debug.Log(oneuser.Length);

		for (i = 0; i < oneuser.Length-1; i++)
		{
			//Debug.Log(oneuser[i]);
			//Debug.Log(oneuser[i]);
			if (i % 2 == 0)
			{
				
				user_nick_name[j] = oneuser[i];
				Debug.Log(user_nick_name[j]);
			}
			else
			{
				user_score[j++] = oneuser[i];
				Debug.Log(user_score[j-1]);
			}
		

		}
		

		yield return WebRequest;
	}


}
