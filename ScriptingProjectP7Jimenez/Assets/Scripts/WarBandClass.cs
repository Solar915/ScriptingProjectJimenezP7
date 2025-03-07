using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
