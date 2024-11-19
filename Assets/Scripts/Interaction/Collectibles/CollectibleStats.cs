using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is used for handling collectible stats,
//Since my collectibles, health potion and coins have values and related to player stats
//This should be abstracted because we need to close this script for supports other scripts that need it
public abstract class CollectibleStats : MonoBehaviour
{
    [SerializeField] protected int value = 10;
}
