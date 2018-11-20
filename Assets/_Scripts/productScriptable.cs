using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "product", menuName = "sellable/product", order = 1)]

public class productScriptable : ScriptableObject {

    [SerializeField] private string name;
    [SerializeField] private float price;
    [SerializeField] private string code;

    public string Name
    {
        get
        {
            return name;
        }
    }

    public float Price
    {
        get
        {
            return price;
        }
    }

    public string Code
    {
        get
        {
            return code;
        }
    }
}
