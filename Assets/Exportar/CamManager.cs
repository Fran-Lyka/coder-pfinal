using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
     public GameObject[] cameras;
    void Start()
    {
    }

    void Update()
    {

     if (Input.GetKeyDown(KeyCode.F5))
     {
       cameras[0].SetActive(true);
       cameras[1].SetActive(false);
       cameras[2].SetActive(false);
     }
      if (Input.GetKeyDown(KeyCode.F6))
     {
       cameras[0].SetActive(false);
       cameras[1].SetActive(true);
       cameras[2].SetActive(false);
     }
     if (Input.GetKeyDown(KeyCode.F7))
       {
       cameras[0].SetActive(false);
       cameras[1].SetActive(false);
       cameras[2].SetActive(true);
       }
    }
}
