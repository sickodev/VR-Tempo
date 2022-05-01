using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandModelController : MonoBehaviour
{
    [SerializeField]GameObject baseHand;
    [SerializeField]GameObject scissorHand;

    public bool isSelected = false;
    // Start is called before the first frame update
    private void Start()
    {
        baseHand.SetActive(true);
        scissorHand.SetActive(false);
    }

    private void Update()
    {
        if(isSelected ==  true)
        {
            Debug.Log("Working");
        }
        else if(isSelected == false)
        {
            Debug.Log("Still Working");
        }
    }


}
