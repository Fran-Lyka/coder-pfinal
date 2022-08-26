using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float posicionX = 1f;
    void Start()
    {
        transform.position = Vector3.up * 2;
        transform.localScale = transform.localScale * 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.forward * Time.deltaTime;
        transform.position = transform.position + Vector3.right * posicionX * Time.deltaTime;
        
    }
}
