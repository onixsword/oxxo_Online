using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cashier : Character3D
{

    [Header("Cashier Variables")]
    [SerializeField] private float throwForce;
    private reticleController reticle;
    private Transform activeObject;

    protected override void inUpdate()
    {
        if (!reticle)
        {
            reticle = transform.Find("head/Main Camera").GetComponent<reticleController>();
        }
        else
        {
            if (Input.GetButtonDown("Fire1") && reticle.IsHitting)
            {
                activeObject = reticle.Hit.transform;
                if (activeObject.CompareTag("product"))
                {
                    activeObject.parent = reticle.transform;
                    activeObject.GetComponent<Rigidbody>().useGravity = false;
                } else if (activeObject.CompareTag("button"))
                {
                    activeObject.GetComponent<Button>().onClick.Invoke();
                    //activeObject.GetComponent<slave>().Master.GetComponent<monitorController>().
                } else if (activeObject.CompareTag("checker"))
                {
                    activeObject.GetComponent<checker>().IsOpened = false;
                }
            }
            else if (Input.GetButtonUp("Fire1"))
            {
                if (activeObject.CompareTag("product"))
                {
                    reticle.transform.GetChild(0).parent = null;
                    activeObject.GetComponent<Rigidbody>().useGravity = true;
                    activeObject = null;
                }
            }
        }
    }
}

