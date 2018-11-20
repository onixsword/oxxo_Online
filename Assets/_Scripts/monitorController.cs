using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monitorController : MonoBehaviour {

    [SerializeField] private Text name;
    [SerializeField] private Text price;
    [SerializeField] private Text total;

    [SerializeField] private checker checker;

    private productScriptable data;
    private float totalValue  = 0f;

    public productScriptable Data
    {
        set
        {
            //DO BEEP
            data = value;
            name.text = "Name: " + data.Name;
            price.text = "Price: " + data.Price;
            totalValue += data.Price;
            total.text = "Total: " + totalValue;
        }
    }

    public void checkOut()
    {
        //DO BEEP
        checker.IsOpened = true;
        cancel();
    }

    public void cancel()
    {
        //DO BEEP
        name.text = "Name: ";
        price.text = "Price: ";
        totalValue = 0f;
        total.text = "Total: " + totalValue;
    }
}
