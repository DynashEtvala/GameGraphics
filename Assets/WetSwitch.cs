using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetSwitch : MonoBehaviour
{
    ParticleSystem particleSystem;
    Animator parentAnimator;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();
        parentAnimator = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (parentAnimator.GetBool("Wet") == true && particleSystem.isPlaying != true)
        {
            particleSystem.Play();
        }
        else if (parentAnimator.GetBool("Wet") == false && particleSystem.isPlaying == true)
        {
            particleSystem.Stop();
        }
    }
}
