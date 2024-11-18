using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : InteractibleStats, IInteractable
{
    public void Interact()
    {
        playerStats.health += value;
        Debug.Log("Health: " + playerStats.health);
        gameObject.SetActive(false);
    }
}
