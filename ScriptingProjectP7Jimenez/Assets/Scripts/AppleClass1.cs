using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple1
{         
   public void Apple()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //These methods are overrides and therefore
    //can override any virtual methods in the parent
    //class.
    public void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public void SayHello() 
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}
