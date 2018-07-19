using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreatePointScripts : MonoBehaviour
{
    float time, shootTime, shootPower, ItemNum,ddolsNum;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        shootTime = Random.Range(0.5f, 1f);
        shootTime = Random.Range(0.5f, 1f);
        shootPower = Random.Range(100, 500);
        ItemNum = Random.Range(1, 5);
        ddolsNum = Random.Range(1, 6);

        if (GameManager.Instance.dollsCount <= 10)
        {
            make();
        }
        if (GameManager.Instance.itemdollsCount <= 5)
        {
            itemmake();
        }
    }

    public void make()
    {
        time += Time.deltaTime; // time = time + Time.deltaTime;
        if (time > shootTime)
        {
            time = 0f;
            GameObject G = Instantiate(Resources.Load("ddols" +ddolsNum)) as GameObject;
            G.transform.position = gameObject.transform.position;
            G.GetComponent<Rigidbody2D>().AddForce(new Vector2(shootPower, shootPower));
            GameManager.Instance.dollsCount++;
            SoundManager.Instance._MakeSound();
            //Debug.Log("ddols : " + GameManager.instance.ddolsCount);
        }
    }
    public void itemmake()
    {
        time += Time.deltaTime;
        if (time > shootTime)
        {

            time = 0f;
            GameObject I = Instantiate(Resources.Load("item" + ItemNum)) as GameObject;
            I.transform.position = gameObject.transform.position;
            I.GetComponent<Rigidbody2D>().AddForce(new Vector2(shootPower, shootPower));
            GameManager.Instance.itemdollsCount++;
            SoundManager.Instance._MakeSound();
			//Debug.Log("ddols : " + GameManager.instance.ddolsCount);
		}
    }
}
