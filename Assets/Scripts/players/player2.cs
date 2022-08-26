using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float posicionY = 3f;
    void Start()
    {
        transform.position = Vector3.up * 5;
        transform.localScale = transform.localScale * 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.up * posicionY * Time.deltaTime;
        
        
    }
}
