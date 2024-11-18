using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapCalculation : MonoBehaviour, IHit
{
    [SerializeField] protected PlayerStats playerStats;
    public void PlayerHit(int damage)
    {

        playerStats.health -= damage;
        Debug.Log("Health: " + playerStats.health);
        if (playerStats.health <= 0)
        {
            Debug.Log("You died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
