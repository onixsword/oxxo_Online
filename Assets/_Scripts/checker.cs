using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class checker : MonoBehaviour {

    [SerializeField] private Transform openPosition;
    private Vector3 initialPosition;
    private Vector3 finalPosition;
    private bool isOpened;

    private void Start()
    {
        initialPosition = transform.position;
        finalPosition = openPosition.position;
        GameObject.Destroy(openPosition.gameObject);
    }

    public bool IsOpened
    {
        get
        {
            return isOpened;
        }

        set
        {
            isOpened = value;
            if (isOpened)
            {
                transform.position = finalPosition;
            }
            else
            {
                transform.position = initialPosition;
            }
        }
    }
}
