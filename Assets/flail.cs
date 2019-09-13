using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flail : MonoBehaviour
{
    Animator animator;
    float burnTime;
    float wetTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        burnTime = 0;
        wetTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(burnTime > 0)
        {
            burnTime -= Time.deltaTime;
        }
        else if(animator.GetBool("On Fire") == true)
        {
            animator.SetBool("On Fire", false);
        }

        if(wetTime > 0)
        {
            wetTime -= Time.deltaTime;
        }
        else if (animator.GetBool("Wet") == true)
        {
            animator.SetBool("Wet", false);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Spark"))
        {
            if (wetTime > 0)
            {
                wetTime -= 0.5f;
            }
            else
            {
                burnTime = 6;
            }

            if (animator.GetBool("On Fire") == false && animator.GetBool("Wet") == false)
            {
                animator.SetBool("On Fire", true);
            }
        }
        if (other.CompareTag("Water"))
        {
            wetTime = 4;

            if (burnTime > 0)
            {
                burnTime = 0;
            }

            if(animator.GetBool("Wet") == false)
            {
                animator.SetBool("Wet", true);
            }

            if(animator.GetBool("On Fire") == true)
            {
                animator.SetBool("On Fire", false);
            }
        }
    }
}
