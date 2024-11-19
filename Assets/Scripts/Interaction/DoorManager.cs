using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use its variables to handle the switch door scripts. Again I make it to be closed.
public abstract class DoorManager : MonoBehaviour
{
    [SerializeField] protected Transform door;
    [SerializeField] protected Transform doorOpenedPos;
    [SerializeField] protected float frequency = 0.5f;
    protected bool isTriggered = false;
}
