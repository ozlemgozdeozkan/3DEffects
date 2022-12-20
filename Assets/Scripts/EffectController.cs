using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController : MonoBehaviour
{
    //public int speed = 2;
    //TrailRenderer trialEffect;
    
    [SerializeField]
    Transform target;
    [SerializeField]
    Transform start;
    LineRenderer lineEffect;
    
    void Start()
    {
        //trialEffect = GetComponentInChildren<TrailRenderer>();
        lineEffect = GetComponentInChildren<LineRenderer>();
    }

    void Update()
    {
        /*trialEffect.startColor = Color.red;
        trialEffect.endColor =  new Color(248f, 118f, 8f);

        transform.Translate(Vector3.up * 2f * Time.deltaTime);
        */
        lineEffect.SetPosition(0, start.position);//Start
        lineEffect.SetPosition(1, target.position);
    }
}
