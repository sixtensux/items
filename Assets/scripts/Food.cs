using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usables
{

    public float saturation;
    public bool isYummy;

    public override void Use()
    {
        if (usesleft > 0 && isYummy == true)
        {
            usesleft -= 1;

            print(YummyToString());
        }
        else if (usesleft > 0)
        {
            usesleft -= 1;
           print(UseText());
        }
        else
        {
            print (NoUsesRemainingText());
        }
    }

    public override string UseText()
    {
        return string.Format("you just drank " + itemName + " you have " + usesleft + " potionsleft.");
    }

    public override string ToString()
    {
       return base.ToString();
    }

    public string YummyToString()
    {
        return string.Format("you drank the " + itemName + " it was yummy + " + saturation + " saturation, you have " + usesleft + " potionsleft.");
    }
}
