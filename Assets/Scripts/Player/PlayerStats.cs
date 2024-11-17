using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
