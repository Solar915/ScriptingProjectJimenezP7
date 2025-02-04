using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    //Member variables can be referred to as
    //fields.
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}
