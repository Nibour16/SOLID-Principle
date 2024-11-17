using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour, ITrap
{
    [SerializeField] private int damage = 1;
    [SerializeField] private PlayerStats playerStats;

    public void PlayerHit()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerStats.Trap(damage);
        }
    }
}
