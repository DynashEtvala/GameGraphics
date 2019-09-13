using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnSwitch : MonoBehaviour
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
        if (parentAnimator.GetBool("On Fire") == true && particleSystem.isPlaying != true)
        {
            particleSystem.Play();
        }
        else if (parentAnimator.GetBool("On Fire") == false && particleSystem.isPlaying == true)
        {
            particleSystem.Stop();
        }
    }
}
