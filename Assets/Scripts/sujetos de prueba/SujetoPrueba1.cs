using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SujetoPrueba1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp = 7;
    public float speed = 1.5f;
    public string NamePlayer = "Bjorn";
    public int attack = 1;
        void Start()
    {
      Debug.Log(hp);
      Debug.Log("sujeto 1 Ejecutado al Inicio");
      transform.position += Vector3.up *1f;  
      damage(attack);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("sujeto 1 Ejecutando update");
        Moveplayer(Vector3.back);
    }

    void damage(int value)
    {
        hp = hp - value;
 
    }
    void Moveplayer(Vector3 direccion)
    {
      transform.position += direccion  * speed * Time.deltaTime;
    }

}  


