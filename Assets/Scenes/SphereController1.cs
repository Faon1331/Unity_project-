using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController1 : MonoBehaviour
{
    private bool isAnimationPlayed = false;

    void Start()
    {
        isAnimationPlayed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isAnimationPlayed)
        {
            GetComponent<Animation>().Play("New Anima321214tion");

            isAnimationPlayed = true;
        }
    }
} /*New Anima321214tion*/