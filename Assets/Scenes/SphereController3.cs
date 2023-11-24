using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController3 : MonoBehaviour
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
            // Воспроизведение анимации надувания сферы 1
            GetComponent<Animation>().Play("New Anima3542525tion");

            isAnimationPlayed = true;
        }
    }
} /*New Anima3542525tion*/