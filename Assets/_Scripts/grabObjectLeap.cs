using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class grabObjectLeap : MonoBehaviour {

    [SerializeField] private CapsuleHand capsuleHandRight;
    [SerializeField] private CapsuleHand capsuleHandLeft;

    private Hand handRight;
    private Hand handLeft;

    private int handRightID;
    private int handLeftID;

    [SerializeField] private remoteTrigger triggerHandRight;
    [SerializeField] private remoteTrigger triggerHandLeft;

    private bool isGrabbingRight;
    private bool isGrabbingLeft;

    [SerializeField] private float sphereRadius;


    private void Start()
    {
        handRight = capsuleHandRight.GetLeapHand();
        handLeft = capsuleHandLeft.GetLeapHand();
    }

    // Update is called once per frame
    void Update () {

        if (capsuleHandRight.gameObject.GetActive())
        {
            handRight = capsuleHandRight.GetLeapHand();
            if (handRight != null) 
            {

                isGrabbingRight = true;
                foreach (Finger f in handRight.Fingers)
                {
                    if (f.IsExtended)
                    {
                        isGrabbingRight = false;
                        break;
                    }
                }

                triggerHandRight.transform.position = handRight.PalmPosition.ToVector3();
                if (triggerHandRight.isCollidingWithTag("product")) {
                    if (isGrabbingRight)
                    {
                        Transform lic = triggerHandRight.LastItemCollided;
                        lic.position = handRight.PalmPosition.ToVector3();
                        lic.GetComponent<Rigidbody>().useGravity = false;
                    } else triggerHandRight.LastItemCollided.GetComponent<Rigidbody>().useGravity = true;
                }
            }
        }

        if (capsuleHandLeft.gameObject.GetActive())
        {
            handLeft = capsuleHandLeft.GetLeapHand();
            if(handLeft != null)
            {

                isGrabbingLeft = true;
                foreach (Finger f in handLeft.Fingers)
                {
                    if (f.IsExtended)
                    {
                        isGrabbingLeft = false;
                        break;
                    }
                }

                triggerHandLeft.transform.position = handLeft.PalmPosition.ToVector3();
                if (triggerHandLeft.isCollidingWithTag("product"))
                {
                    if (isGrabbingLeft)
                    {
                        Transform lic = triggerHandLeft.LastItemCollided;
                        lic.position = handLeft.PalmPosition.ToVector3();
                        lic.GetComponent<Rigidbody>().useGravity = false;
                    }
                    else triggerHandLeft.LastItemCollided.GetComponent<Rigidbody>().useGravity = true;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (capsuleHandRight.gameObject.GetActive())
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(handRight.PalmPosition.ToVector3(), sphereRadius);
        }

        if (capsuleHandLeft.gameObject.GetActive())
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(handLeft.PalmPosition.ToVector3(), sphereRadius);
        }
    }
}
