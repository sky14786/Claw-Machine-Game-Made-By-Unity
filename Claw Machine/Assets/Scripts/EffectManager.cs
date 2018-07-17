using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManager : MonoBehaviour
{
    public static EffectManager instance;
    public List<ParticleSystem> particleList;
    public GameObject EffectPoint,G;
    //public float onesec = 1f;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("Game Manager Call Success !");
        }
    }


    public void  Update()
    {
        for(int i=0; i < particleList.Count; i++)
        {
            if(!particleList[i].isPlaying)
            {
                GameObject obj = particleList[i].gameObject;
                particleList.Remove(particleList[i]);
                Destroy(obj);
               
            }

        }
    }
        public void _EfOn(int a)
    {
        if (a == 1)
        {
            G = Instantiate(Resources.Load("Hearts_02") as GameObject);
           G.transform.position = EffectPoint.transform.position;
            particleList.Add(G.GetComponent<ParticleSystem>());
           
        }
        else
        {
             G = Instantiate(Resources.Load("Fx_OilSplashHIGH_Root") as GameObject);
           G.transform.position =EffectPoint.transform.position;
            particleList.Add(G.GetComponent<ParticleSystem>());

        }
    }
    

}
