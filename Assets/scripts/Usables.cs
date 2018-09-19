using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usables : Items
{
    public float usesleft;

    public string text;


    public void OnMouseUpAsButton()
    {
        Use();
        UseText();
    }

    public virtual void Use()
    {
        if (usesleft > 0)
        {
            usesleft -= 1;
            print(UseText());
        }
        else
        {
            print(NoUsesRemainingText());
        }
    }

    public virtual string UseText()
    {
        return string.Format("you just used " + itemName + " you have " + usesleft + " uses remaining."); ;
    }

    public virtual string NoUsesRemainingText()
    {
        return string.Format("you can't use this item...Nerd"); ;
    }

    public override string ToString()
    {
        return base.ToString()  + "it has " + usesleft + " usesleft.";
    }
}
