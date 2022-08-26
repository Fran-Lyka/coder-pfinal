using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemigo : MonoBehaviour
{
    public Animator ani;
    public skeletons enemigo;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("PJ"))
        {
            ani.SetBool("walk", false);
            ani.SetBool("run", false);
            ani.SetBool("attack", true);
            enemigo.atacando = true;
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
