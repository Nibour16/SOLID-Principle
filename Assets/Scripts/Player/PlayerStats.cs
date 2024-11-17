using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int health = 4;
    public int score = 0;

    public void GetCoin(int value, GameObject obj)
    {
        score += value;
        Debug.Log("Score: " + score);
        obj.SetActive(false);
    }

    public void GetHP(int value, GameObject obj)
    {
        health += value;
        Debug.Log("Health: " + health);
        obj.SetActive(false);
    }

    public void Trap(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);
        if (health <= 0)
        {
            Debug.Log("You died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
