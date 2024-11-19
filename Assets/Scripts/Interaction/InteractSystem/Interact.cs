using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handle interact functions
public class Interact : MonoBehaviour
{
    [SerializeField] private Transform interactSource;
    [SerializeField] private float interactDistance;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))    //if press left mouse button
        {
            Act();  //Call act function to start create a ray to detect something
        }
    }

    private void Act()
    {
        Ray ray = new Ray(interactSource.position, interactSource.forward); //create a ray that can check out if something can be interacted
        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance)) //if the ray hits something
        {
            StartInteract(hit);
        }
    }

    private void StartInteract(RaycastHit hit)
    {
        Debug.Log(hit.collider.gameObject.name);    //Check the interacted object name

        if (hit.collider.gameObject.GetComponent<IInteractable>() != null)  //If the interacted object has connected to the interface IInteractable
        {
            //Run the interact method, depending on the object's job.
            IInteractable iInteractable = hit.collider.gameObject.GetComponent<IInteractable>();
            iInteractable.Interact();
        }
    }
}
