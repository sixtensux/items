using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

    public string itemName;

    public float Weight;
    public float pricePerWeight;
    public float cost = 0;

    public float GetPricePerWeight()
    {
        cost = Weight / pricePerWeight;

        return cost;
    }


    public override string ToString()
    {
        return "this is a " + itemName + "it cost's "
            + cost + " ";
    }

    public virtual void OnMouseEnter()
    {
        Debug.Log(ToString()); 

    }
}
