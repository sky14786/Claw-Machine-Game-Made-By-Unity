using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DDolsController : MonoBehaviour
{
	public AudioSource MakeSource;
	public AudioClip MakeSound;
    float time, shootTime, shootPower, objectNum;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        shootTime = Random.Range(0.5f, 1f);
        shootPower = Random.Range(100, 500);
        objectNum = Random.Range(1, 5);

        if (GameManager.instance.ddolsCount <= 10)
        {
            make();
        }
        if (GameManager.instance.itemddolsCount <= 5)
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
            GameObject G = Instantiate(Resources.Load("ddols" + Random.Range(1, 6))) as GameObject;
            G.transform.position = gameObject.transform.position;
            G.GetComponent<Rigidbody2D>().AddForce(new Vector2(shootPower, shootPower));
            GameManager.instance.ddolsCount++;
			MakeSource.PlayOneShot(MakeSound);
            //Debug.Log("ddols : " + GameManager.instance.ddolsCount);
        }
    }
    public void itemmake()
    {
        time += Time.deltaTime;
        if (time > shootTime)
        {

            time = 0f;
            GameObject I = Instantiate(Resources.Load("item" + objectNum)) as GameObject;
            I.transform.position = gameObject.transform.position;
            I.GetComponent<Rigidbody2D>().AddForce(new Vector2(shootPower, shootPower));
            GameManager.instance.itemddolsCount++;
			MakeSource.PlayOneShot(MakeSound);
			//Debug.Log("ddols : " + GameManager.instance.ddolsCount);
		}
    }
}
