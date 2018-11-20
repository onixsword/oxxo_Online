using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]

public class insertInView : MonoBehaviour {


    private void Start()
    {
        transform.GetComponent<PhotonView>().ObservedComponents.Add(transform);
    }

}
