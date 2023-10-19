using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnSnap : MonoBehaviour
{
    // Reference to the XR Socket Interactor
    public XRSocketInteractor socketInteractor;

    // Reference to the mesh renderer or other renderer component
    public Renderer objectRenderer;

    private void Start()
    {
        // Subscribe to the Socket Interactor's OnSelectEntered and OnSelectExited events
        socketInteractor.onSelectEntered.AddListener(HandleSnap);
        socketInteractor.onSelectExited.AddListener(HandleUnsnap);

        // Initially, set the object as visible
        objectRenderer.enabled = true;
    }

    private void HandleSnap(XRBaseInteractable obj)
    {
        // Hide the object when snapped
        objectRenderer.enabled = false;
    }

    private void HandleUnsnap(XRBaseInteractable obj)
    {
        // Show the object when unsnapped
        objectRenderer.enabled = true;
    }
}