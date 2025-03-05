using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit1 : MonoBehaviour
{
    public Fruit1 ()
    {
        Debug.Log("1st Fruit Constructor Called");
    }
    // Start is called before the first frame update
    public virtual void Chop1()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello1()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
