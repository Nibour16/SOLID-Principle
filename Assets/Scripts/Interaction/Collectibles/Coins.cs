using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//Coin Collectible
public class Coins : CollectibleStats, IInteractable
{
    public void Interact()  //Get a coin
    {
        GetCoin();
    }

    private void GetCoin()  //Coin function (get score by its value)
    {
        playerStats.score += value;
        Debug.Log("Score: " + playerStats.score);
        gameObject.SetActive(false);
    }
}
