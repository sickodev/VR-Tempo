using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScissorHandConroller : MonoBehaviour
{

    [SerializeField] InputActionReference triggerInputAction;

    Animator scissorAnimator;
    int TriggerHash;
    int PrimaryButtonHash;

    Collider other;

    

    // Start is called before the first frame update
    void Awake()
    {
        scissorAnimator = GetComponent<Animator>();

        TriggerHash = Animator.StringToHash("Trigger");
    }

    private void OnEnable()
    {
        triggerInputAction.action.performed += TriggerPressed;
    }

    private void PrimaryButtonPressed(InputAction.CallbackContext obj)
    {
       scissorAnimator.SetFloat(PrimaryButtonHash,obj.ReadValue<float>());
    }

    private void TriggerPressed(InputAction.CallbackContext obj)
    {
        float trigger = obj.ReadValue<float>();
        //Debug.Log(trigger + " first");

        trigger = (float)Math.Round(trigger, 2);
        Debug.Log(trigger + " after trim");

        /**if (trigger <= 0.1f)
        {
            trigger = 0.0f;
        }
        else if (trigger >= 1.0f)
        {
            trigger = 1.0f;
        }*/

        scissorAnimator.SetFloat(TriggerHash,trigger);
        //Debug.Log(trigger);

        

    }



    private void OnDisable()
    {
        triggerInputAction.action.performed -= TriggerPressed;
    }
}
