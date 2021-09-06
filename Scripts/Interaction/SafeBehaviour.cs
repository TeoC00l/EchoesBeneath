//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using System.Collections;
using UnityEngine;

public class SafeBehaviour : MonoBehaviour
{
    private Animator safeAnim;
    private static readonly int Safe = Animator.StringToHash("OpenSafe");
    [SerializeField] private GameObject _artifact;

    private void Awake()
    {
        safeAnim = transform.GetComponent<Animator>();
    }

    public void OpenSafe()
    {
        _artifact.SetActive(true);
        if (safeAnim != null)
        {
            safeAnim.SetTrigger(Safe);
        }
        else
        {
            Debug.LogWarning("Warning : Animator on Safe Was not found");
        }
    }
    
}
