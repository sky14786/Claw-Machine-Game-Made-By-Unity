using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectMaker : MonoBehaviour
{
    private static EffectMaker instance;

    public static EffectMaker Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new EffectMaker();
            }
            return instance;
        }
        
    }

    public GameObject EffectPoint;
   

    public void MakeOfEffect(int a)
    {
        switch (a)
        {
            case 1:
                GameObject DdolsDead = Instantiate(Resources.Load("Hearts_02") as GameObject);
                DdolsDead.transform.position = EffectPoint.transform.position;
                break;
            case 2:
                GameObject ItemsDead = Instantiate(Resources.Load("Fx_OilSplashHIGH_Root") as GameObject);
                ItemsDead.transform.position = EffectPoint.transform.position;
                break;
        }

    }

}
