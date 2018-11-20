using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]

public class product : MonoBehaviour {

    [SerializeField] private productScriptable data;

    public productScriptable Data
    {
        get
        {
            return data;
        }
    }
}
