using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform door;
    [SerializeField] private Transform doorOpenedPos;
    [SerializeField] private float frequency = 0.5f;

    private bool isTriggered = false;
    public void Interact()
    {
        triggerSwitch();
    }

    private void triggerSwitch()
    {
        Debug.Log("triggered");
        isTriggered = true;
    }

    private void Update()
    {
        if (isTriggered)
        {
            door.position = Vector3.MoveTowards(door.position, doorOpenedPos.position, Time.time * frequency / 100);
        }
    }
}
