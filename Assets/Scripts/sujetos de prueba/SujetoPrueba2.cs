using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SujetoPrueba2 : MonoBehaviour
{
    // Start is called before the first frame update
  public int hp = 7;
  public float speed = 1.5f;
  public string NamePlayer = "Od";
  public int healing = 1;
  
    void Start()
    {
        Debug.Log(hp);
       Debug.Log("sujeto 2 Ejecutado al Inicio");
       health(healing);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("sujeto 2 Ejecutando update");
        Moveplayer(Vector3.forward);
        
    }
    void health(int value)
    {
       hp = hp + value;
    }

    void Moveplayer(Vector3 direccion)
    {
       transform.position += direccion * speed * Time.deltaTime;
    }
        
    
}
