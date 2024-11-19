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
        PlayerStats.Instance.score += value;
        Debug.Log("Score: " + PlayerStats.Instance.score);
        gameObject.SetActive(false);
    }
}
