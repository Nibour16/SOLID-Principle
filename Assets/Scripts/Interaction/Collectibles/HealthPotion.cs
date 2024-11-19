using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Health Potion Collectible
public class HealthPotion : CollectibleStats, IInteractable
{
    public void Interact()  //Get a health potion
    {
        GetHP();
    }

    private void GetHP()   //Health potion function for add player's HP by its value
    {
        playerStats.health += value;
        Debug.Log("Health: " + playerStats.health);
        gameObject.SetActive(false);
    }
}
