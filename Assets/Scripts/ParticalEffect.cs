using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalEffect : MonoBehaviour
{
    ParticleSystem part;

    
    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            part.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            part.Play();
        }
    }
    private void OnParticleSystemStopped()
    {
        transform.Rotate(40f, 0, 0);
    }
}
