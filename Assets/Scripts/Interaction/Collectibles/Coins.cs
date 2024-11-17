using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coins : MonoBehaviour, IInteractable
{
    [SerializeField] private int value = 10;
    [SerializeField] private PlayerStats playerStats;

    public void Interact()
    {
        playerStats.GetCoin(value, gameObject);
    }
}
