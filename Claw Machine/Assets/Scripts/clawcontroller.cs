using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{

    public float angle;
    public bool isLeft, isPlaying;

    void FixedUpdate()
    {
        angle = transform.localEulerAngles.z;
        angle = (angle > 180) ? angle - 360 : angle;

        if (isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
                StartCoroutine(_Tighten());
            //if (MobileMovementManager.instance.tightn)
            //    StartCoroutine(_Tighten()); 
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
                StartCoroutine(_Untie());
            //if (!MobileMovementManager.instance.tightn)
            //    StartCoroutine(_Untie());
        }

    }
    void Awake()
    {
        isPlaying = true;
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
    public IEnumerator _Tighten()
    {

        while (true)
        {
            yield return new WaitForSecondsRealtime(Time.deltaTime);
            if (isLeft)
            {
                if (angle > -13f && angle <= 43f)
                    transform.Rotate(0, 0, 2f);
                else
                {
                    isPlaying = false;
                    //MobileMovementManager.instance.tightn = false;
                    break;
                }

            }
            else
            {
                if (angle < 13f && angle >= -43f)
                    transform.Rotate(0, 0, -2f);
                else
                {
                    //MobileMovementManager.instance.tightn = false;
                    isPlaying = false;
                    break;
                }

            }
        }

    }
    public IEnumerator _Untie()
    {

        while (true)
        {
            yield return new WaitForSecondsRealtime(Time.deltaTime);
            if (isLeft)
            {
                if (angle > -11f && angle < 45f)
                    transform.Rotate(0, 0, -2f);
                else
                {
                    //MobileMovementManager.instance.tightn = true;
                    isPlaying = true;
                    break;
                }

            }
            else
            {
                if (angle < 11f && angle > -45f)
                    transform.Rotate(0, 0, 2f);
                else
                {
                    //MobileMovementManager.instance.tightn = true;
                    isPlaying = true;
                    break;
                }

            }

        }

    }
}