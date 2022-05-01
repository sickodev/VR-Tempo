using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandModelChange : MonoBehaviour
{
    [SerializeField] GameObject BaseHandModel;
    [SerializeField] GameObject CustomHandModel;

    [SerializeField] GameObject lowerSurface;
    [SerializeField] GameObject upperSurface;

    private void Start()
    {
        BaseHandModel.SetActive(true);
        CustomHandModel.SetActive(false);
    }
    public void OnSelectEnter()
    {
        //this.gameObject.SetActive(false);
        BaseHandModel.SetActive(false);
        CustomHandModel.SetActive(true);

        lowerSurface.SetActive(false);
        upperSurface.SetActive(false);

        this.GetComponent<BoxCollider>().enabled = false;
    }

    public void OnSelectExit()
    {
        //this.gameObject.SetActive(true);
        BaseHandModel.SetActive(true);
        CustomHandModel.SetActive(false);

        lowerSurface.SetActive(true);
        upperSurface.SetActive(true);

        this.GetComponent<BoxCollider>().enabled = true;
    }
    
}
