using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController2 : MonoBehaviour
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
            // ��������������� �������� ��������� ����� 1
            GetComponent<Animation>().Play("New A5325nimation");

            isAnimationPlayed = true;
        }
    }
} /*New A5325nimation*/
