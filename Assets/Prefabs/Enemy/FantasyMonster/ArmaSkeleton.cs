using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSkeleton : MonoBehaviour
{
    public GameObject enemigo;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("PJ"))
        {
            print("Daño");
        }
        if (coll.CompareTag("escudo"))
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            print("Bloqueo");
        }
        if (coll.CompareTag("parry"))
        {
            enemigo.GetComponent<skeletons>().stuneado = true;
            enemigo.GetComponent<Animator>().SetBool("stun", true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
