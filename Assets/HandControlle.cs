using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControlle : MonoBehaviour
{
    [SerializeField]
    GameObject BulletPrefab;

    ActionBasedController controller;

    void Awake()
    {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTriggerPress;
    }

    void OnTriggerPress(InputAction.CallbackContext context)
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
