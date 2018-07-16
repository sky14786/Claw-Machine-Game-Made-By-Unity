using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadEffectScripts : MonoBehaviour
{
    ParticleSystem particle;
    public float onesec = 1f;

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    public void Update()
    {
        if (!particle.isPlaying)
        {
            //onesec -= Time.deltaTime;
            //if (onesec <= 0)
            //{
            //    Destroy(gameObject);
            //    onesec = 1f;
            //}
            Destroy(gameObject);
        }


        //float onesec = 1f;
        //onesec -= Time.deltaTime;
        //if (onesec <= 1f)
        //{

        //    UIManager.instance.DeadEffect.GetComponent<ParticleSystem>();
        //    Destroy(UIManager.instance.DeadEffect);
        //}
    }

}
