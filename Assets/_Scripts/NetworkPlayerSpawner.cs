using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayerSpawner : MonoBehaviour
{
    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
        Vector3 position = new Vector3(0f, 0.12f, 0f);

        GameObject newPlayerObject = PhotonNetwork.Instantiate("BobCashier", position, Quaternion.identity, 0);

        //Camera.Target = newPlayerObject.transform;
    }
}
