using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Trigger : MonoBehaviour
{
   [SerializeField] private Animator myAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimator.SetBool("PlayerCollider", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {   Debug.Log("trriggered");
            myAnimator.SetBool("PlayerCollider", false);
        }
    }
}
