using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour {

    void Start() { 
        GameManager.instance.MoveSpeed = 0.1f;
    }

    void FixedUpdate() {
        if (Input.GetKey(KeyCode.DownArrow)) {
            moveDown();
        }else if (Input.GetKey(KeyCode.UpArrow)) {
            moveUp();
        }else if (Input.GetKey(KeyCode.LeftArrow)) {
            moveLeft();
        }else if (Input.GetKey(KeyCode.RightArrow)) {
            moveRight();
        }
    }

    void Update() {
        if (GameManager.instance.PowerTime >= 0)
        {
            GameManager.instance.MoveSpeed = 0.2f;
            GameManager.instance.PowerTime -= Time.deltaTime;
        }else {
            GameManager.instance.MoveSpeed = 0.1f;
        }
    }

    void moveUp() {
        if (transform.position.y < 1.076795f) {
            gameObject.transform.Translate(0, GameManager.instance.MoveSpeed, 0);
        }
    }

    void moveDown() {
        if (transform.position.y >= -5.4f) {
            gameObject.transform.Translate(0, -GameManager.instance.MoveSpeed, 0);
        }
    }

    void moveLeft() {
        if (transform.position.x > -7.8178f) {
            gameObject.transform.Translate(-GameManager.instance.MoveSpeed, 0, 0);
        }
    }

    void moveRight() {
        if (transform.position.x < 6.382194f)
        {
            gameObject.transform.Translate(GameManager.instance.MoveSpeed, 0, 0);
        }
    }
}

