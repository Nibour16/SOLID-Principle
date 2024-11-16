using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleTest : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("lorem ipsum dolor sit amet");
    }
}
