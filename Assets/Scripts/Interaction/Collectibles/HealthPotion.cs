using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour, IInteractable
{
    [SerializeField] private int value = 1;
    [SerializeField] private PlayerStats playerStats;

    public void Interact()
    {
        playerStats.GetHP(value, gameObject);
    }
}
