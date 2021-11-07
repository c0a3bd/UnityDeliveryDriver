using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private GameObject DeliveryDriver;

    private void Start() 
    {
        // https://docs.unity3d.com/ScriptReference/GameObject-ctor.html
        // https://docs.unity3d.com/ScriptReference/Transform.Rotate.html

        DeliveryDriver = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        DeliveryDriver.transform.position = new Vector3(-2.4f, 0, 0);
        DeliveryDriver.GetComponent<Renderer>().material.color = Color.cyan;
        DeliveryDriver.name = "DeliveryDriver";
    }    

    // Update is called once per frame
    void Update()
    {
        // makes the capsule rotate in a continuous circle
        // depending on your refresh rate, lower the z entry
        DeliveryDriver.transform.Rotate(-2.4f, 0, 10, Space.Self);
    }
}
