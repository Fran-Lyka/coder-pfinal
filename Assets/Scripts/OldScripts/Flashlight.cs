using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
        InvokeRepeating("Battery", 1f, 1f);
    }

    void Update()
    {
        
    }
    void Battery()
    {
        if(myLight.intensity == 0) CancelInvoke("Battery");
    }
}
