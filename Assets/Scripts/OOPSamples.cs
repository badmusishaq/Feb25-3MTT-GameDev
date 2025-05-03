using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPSamples : MonoBehaviour
{
    //public string consoleMessage;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(consoleMessage);

        //Create objects of ObjectOrientedClass
        ObjectOrientedClass tBawo = new ObjectOrientedClass();
        //tBawo.message = "My name is T.Bawo";
        tBawo.PrintMessage("My name is T.Bawo");


        ObjectOrientedClass abdulSalam = new ObjectOrientedClass();
        //abdulSalam.message = "My name is AbdulSalam";
        abdulSalam.PrintMessage("My name is AbdulSalam");


        ObjectOrientedClass jeremiah = new ObjectOrientedClass();
        //jeremiah.message = "My name is Jerry";
        jeremiah.PrintMessage("My name is Jerry");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public class ObjectOrientedClass
{
    public void PrintMessage(string myCustomMessage) //A method with a parameter
    {
        Debug.Log(myCustomMessage);
    }
}
