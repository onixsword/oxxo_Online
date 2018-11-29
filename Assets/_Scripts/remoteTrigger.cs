using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class remoteTrigger : MonoBehaviour {

    private Transform lastItemCollided;

    private void OnTriggerEnter(Collider other)
    {
        lastItemCollided = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if (lastItemCollided == other.transform) lastItemCollided = null;
    }

    public Transform lastItemCollidedWithTag(string Tag)
    {
        if (lastItemCollided.CompareTag(Tag)) return lastItemCollided;
        else return null;
    }

    public Transform LastItemCollided
    {
        get
        {
            return lastItemCollided;
        }
    }

    public bool isColliding
    {
        get
        {
            return (lastItemCollided != null);
        }
    }

    public bool isCollidingWithTag(string Tag)
    {
        if(lastItemCollided) if (lastItemCollided.CompareTag(Tag)) return true;
        return false;
    }
}
