using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithEnemy : MonoBehaviour
{
    private int colllisionCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            colllisionCount += 1;
        }
    }
}
