using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletons : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;

    public GameObject target;
    public bool atacando;
    public GameObject arma;
    public bool stuneado;
    public RangoEnemigo rango;


    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("arma"))
        {
            print("Daño");
        }
    }



    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Player");

    }

    public void Comportamiento_Enemigo()
    {
        if(Vector3.Distance(transform.position, target.transform.position) > 5)
     {
        ani.SetBool("run", false);
        cronometro += 1 *Time.deltaTime;
        if (cronometro >=4)
        {
            rutina = Random.Range(0, 2);
            cronometro = 0;
        }
        switch (rutina)
        {
            case 0:
            ani.SetBool("walk", false);
            break;

            case 1:
            grado = Random.Range(0, 360);
            angulo = Quaternion.Euler(0, grado, 0);
            rutina++;
            break;

            case 2:
            transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
            transform.Translate(Vector3.forward * 1 * Time.deltaTime);
            ani.SetBool("walk", true);
            break;
        }
      }
      else
     {
        var lookPos = target.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);

        if(Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando)
      {
        
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
        ani.SetBool("walk", false);

        ani.SetBool("run", true);
        transform.Translate(Vector3.forward * 2 * Time.deltaTime);

        ani.SetBool("attack", false);

      }
      else
      {
        if (!stuneado)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
        ani.SetBool("walk", false);
        ani.SetBool("run", false);

        ani.SetBool("attack", true);
        atacando = true;
        }
      }
     }
    }
    public void Final_Ani()
    {
        ani.SetBool("attack", false);
        atacando = false;
        stuneado = false;
        rango.GetComponent<CapsuleCollider>().enabled = true;
    }

    public void ColliderWeaponTrue()
    {
        arma.GetComponent<BoxCollider>().enabled = true;
    }
    public void ColliderWeaponFalse()
    {
        arma.GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {
       Comportamiento_Enemigo(); 
    }
}
