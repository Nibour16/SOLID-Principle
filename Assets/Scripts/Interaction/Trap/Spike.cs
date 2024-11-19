using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Ground spikes, or just spike.
public class Spike : TrapCalculation
{
    [SerializeField] private int damage;

    private void OnTriggerEnter(Collider other) //if the player collides the spike
    {
        if (other.CompareTag("Player"))
        {
            PlayerHit(damage);  //call the damage calculation from TrapCalculation class
        }
    }
}
