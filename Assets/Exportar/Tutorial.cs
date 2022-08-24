using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
   public float lifetime = 4f;

    void Start()
    {
        Invoke("HideToriel", lifetime);
    }

    void Update()
    { 
    }

    void HideToriel()
    {
        Destroy(gameObject);
    }
}
