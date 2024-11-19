using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Switch for open a door
public class Switch : DoorManager, IInteractable
{
    public void Interact()  //Interaction for trigger the switch
    {
        triggerSwitch();
    }

    private void triggerSwitch()    //Successfully triggered
    {
        Debug.Log("triggered");
        isTriggered = true;
    }

    private void Update()
    {
        if (isTriggered)    //If switch is on
        {
            //Door is opened by move the door object to certain position
            door.position = Vector3.MoveTowards(door.position, doorOpenedPos.position, Time.time * frequency / 100);
        }
    }
}
