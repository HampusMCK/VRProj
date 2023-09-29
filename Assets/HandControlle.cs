using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControlle : MonoBehaviour
{

    ActionBasedController controller;

    void Awake()
    {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTriggerPress;
    }

    void OnTriggerPress(InputAction.CallbackContext context)
    {
        XRRayInteractor interactor = GetComponentInChildren<XRRayInteractor>();

        foreach (IXRSelectInteractable interactable in interactor.interactablesSelected)
        {
            GameObject probablyGun = interactable.transform.gameObject;

            if (probablyGun.TryGetComponent<GunController>(out GunController c))
            {
                c.PullTrigger();
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
