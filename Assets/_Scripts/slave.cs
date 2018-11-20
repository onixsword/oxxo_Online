using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slave : MonoBehaviour {

    [SerializeField] private Transform master;

    public Transform Master
    {
        get
        {
            return master;
        }

        set
        {
            master = value;
        }
    }
}
