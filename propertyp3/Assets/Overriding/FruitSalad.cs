using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple1 myApple1 = new Apple1();

        myApple1.SayHello1();
        myApple1.Chop1();

        Fruit1 myFruit1 = new Apple1();
        myFruit1.SayHello1();
        myFruit1.Chop1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
