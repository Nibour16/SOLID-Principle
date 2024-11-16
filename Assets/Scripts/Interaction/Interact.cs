using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private Transform interactSource;
    [SerializeField] private float interactDistance;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Act();
        }
    }

    private void Act()
    {
        Ray ray = new Ray(interactSource.position, interactSource.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
        {
            StartInteract(hit);
        }
    }

    private void StartInteract(RaycastHit hit)
    {
        Debug.Log(hit.collider.gameObject.name);

        if (hit.collider.gameObject.GetComponent<IInteractable>() != null)
        {
            IInteractable iInteractable = hit.collider.gameObject.GetComponent<IInteractable>();
            iInteractable.Interact();
        }
    }
}
