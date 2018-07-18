using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {
    public ParticleSystem Effect;
    void Awake()
    {
        Effect = GetComponent<ParticleSystem>();

    }
	void Update () {
	if(!Effect.isPlaying)
        {
            Destroy(gameObject);
        }
          
	}
}
