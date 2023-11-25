using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController3 : MonoBehaviour
{
    private bool isAnimationPlayed = false;
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        isAnimationPlayed = false;
        anim.SetInteger("isPlaying", 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            anim.SetInteger("isPlaying", 1);
        }
    }
} /*New Anima3542525tion*/