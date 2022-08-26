using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("ENTRANDO EN COLISIÓN CON ->" + other.gameObject.name);
    }
    void OnCollisionExit(Collision other)
    {
        Debug.Log("SALIENDO DE COLISIÓN CON ->" + other.gameObject.name);
    }
    void OnCollisionStay(Collision other)
    {
        Debug.Log("EN CONTACTO CON ->" + other.gameObject.name);
    }

   
}
