using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodycontroller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameManager.instance.MoveSpeed = 0.1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
            moveDown();
        if (Input.GetKey(KeyCode.UpArrow))
            moveUp();
        if (Input.GetKey(KeyCode.LeftArrow))
            moveLeft();
        if (Input.GetKey(KeyCode.RightArrow))
            moveRight();
    }
    void Update()
    {
        if (GameManager.instance.PowerTime >= 0)
        {
            GameManager.instance.MoveSpeed = 0.2f;
            GameManager.instance.PowerTime -= Time.deltaTime;
        }
        else
            GameManager.instance.MoveSpeed = 0.1f;
    
    }

    void moveUp()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("UpArrow position x : " + transform.position.x);
            //Debug.Log("UpArrow position y : " + transform.position.y);

            if (transform.position.y < 1.076795f)
                gameObject.transform.Translate(0, GameManager.instance.MoveSpeed, 0);
        }
    }
    void moveDown()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.x > 1.482f && transform.position.y < -1.15f) { }
            else
            {
                if (transform.position.y >= -5.4f)
                    gameObject.transform.Translate(0, -GameManager.instance.MoveSpeed, 0);
            }
        }
    }
    void moveLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("LeftArrow position x : " + transform.position.x);
            //Debug.Log("LeftArrow position y : " + transform.position.y);
            if (transform.position.x > -7.8178f)
                gameObject.transform.Translate(-GameManager.instance.MoveSpeed, 0, 0);
        }
    }

    void moveRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {


            if (transform.position.x > 0.582197f && transform.position.y < -3.0f && transform.position.x < 2.2f)
            {
            }
            else
            {
                if (transform.position.x < 6.382194f)
                {
                    gameObject.transform.Translate(GameManager.instance.MoveSpeed, 0, 0);
                }
            }
        }
    }
}

