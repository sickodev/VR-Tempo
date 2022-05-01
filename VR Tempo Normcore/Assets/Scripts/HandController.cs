using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{

    [SerializeField] InputActionReference gripPressed;
    [SerializeField] InputActionReference triggerPressed;

    Animator handAnimator;

    private void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        gripPressed.action.performed += GripPressed;
        triggerPressed.action.performed += TriggerPressed;
    }

    private void OnDisable()
    {
        gripPressed.action.performed -= GripPressed;
        triggerPressed.action.performed -= TriggerPressed;
    }

    private void TriggerPressed(InputAction.CallbackContext obj)
    {
        
        handAnimator.SetFloat("Trigger",obj.ReadValue<float>());
    }

    private void GripPressed(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip",obj.ReadValue<float>());
    }
}
