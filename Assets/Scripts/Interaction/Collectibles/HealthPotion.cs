using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : CollectibleStats, IInteractable
{
    public void Interact()
    {
        GetHP();
    }

    private void GetHP()
    {
        playerStats.health += value;
        Debug.Log("Health: " + playerStats.health);
        gameObject.SetActive(false);
    }
}
