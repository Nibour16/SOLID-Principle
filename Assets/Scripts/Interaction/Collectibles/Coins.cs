using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coins : InteractibleStats, IInteractable
{
    public void Interact()
    {
        playerStats.score += value;
        Debug.Log("Score: " + playerStats.score);
        gameObject.SetActive(false);
    }
}
