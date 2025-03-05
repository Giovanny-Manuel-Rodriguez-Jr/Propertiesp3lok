using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple1 : Fruit1
{
    public Apple1()
    {
        Debug.Log("1st Apple Constructor Called");
    }
    // Start is called before the first frame update
    public override void Chop1()
    {
        base.Chop1();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello1()
    {
        base.SayHello1();
        Debug.Log("Hello, I am an apple.");
    }

}
