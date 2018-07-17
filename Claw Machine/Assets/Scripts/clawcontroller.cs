using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{

    public float angle;
    public bool isLeft;

    void FixedUpdate()
    {
        angle = transform.localEulerAngles.z;
        angle = (angle > 180) ? angle - 360 : angle;

        if (Input.GetKey(KeyCode.LeftControl))
            Tighten();
        if (Input.GetKey(KeyCode.LeftShift))
            Untie();

    }

    void Tighten()
    {
        if (isLeft)
        {
            if (angle > -13f && angle <= 43f)
                transform.Rotate(0, 0, 2f);
        }
        else
        {
            if (angle < 13f && angle >= -43f)
                transform.Rotate(0, 0, -2f);
        }
    }

    void Untie()
    {
        if (isLeft)
        {
            if (angle > -11f && angle < 45f)
                transform.Rotate(0, 0, -2f);
        }
        else
        {
            if (angle < 11f && angle > -45f)
                transform.Rotate(0, 0, 2f);
        }
    }

}