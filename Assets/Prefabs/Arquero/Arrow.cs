using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private int dmgPoints = 2;
    public float speed = 1;
    public int DMG { get {return dmgPoints;}}

    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
