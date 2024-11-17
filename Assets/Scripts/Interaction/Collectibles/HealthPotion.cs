using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour, IInteractable, ICollectable
{
    [SerializeField] private int value = 1;
    [SerializeField] private PlayerStats playerStats;

    public void Interact()
    {
        Collect();
    }
    public void Collect()
    {
        playerStats.GetHP(value, gameObject);
    }
}
