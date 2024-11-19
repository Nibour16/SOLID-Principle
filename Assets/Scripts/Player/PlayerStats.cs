using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    //This one is just handle the player stats,
    //this one should be opened because we need to drag it into Game Manager
    //to handle the variables (like you want the player's HP to be 10 rather than 4
    //or you want the player starts with score 100 rather than just 0)

    private static PlayerStats _instance;

    public int health = 4;
    public int score = 0;

    public static PlayerStats Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
    }
}
