using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class lector : MonoBehaviour {

    [SerializeField] private monitorController monitor;

    private bool isReading;
    private product currentProduct;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
        if (other.transform.CompareTag("product"))
        {
            monitor.Data = other.GetComponent<product>().Data;
        }

        /*if(!currentProduct) currentProduct = other.GetComponent<product>();
        product newProduct = other.GetComponent<product>();
        if (currentProduct.transform != newProduct.transform)
        {   //nuevo objeto
            currentProduct = newProduct;
        }*/
    }

}
