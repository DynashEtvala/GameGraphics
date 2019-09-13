using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkController : MonoBehaviour
{
    ParticleSystem particleSystem;
    float curSpeed;
    public float slideVal;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        curSpeed = particleSystem.main.startSpeed.constant;
    }

    // Update is called once per frame
    void Update()
    {
        var main = particleSystem.main;
        main.startSpeed = new ParticleSystem.MinMaxCurve(Mathf.Lerp(2, 10, slideVal));
    }

    public void OnValueChanged(float newValue)
    {
        slideVal = newValue;
    }
}
