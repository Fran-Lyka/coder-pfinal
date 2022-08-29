using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public Animator ani;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField]
    [Range(1f,50f)]
    private float rayDistance = 10f;
    [SerializeField] private GameObject bullet;
     
    bool canShoot = true;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
     ShootRaycast();
    }

    void ShootRaycast()
    {
         RaycastHit hit;
        if(Physics.Raycast(shootPoint.position, shootPoint.transform.TransformDirection(Vector3.forward), out hit, rayDistance))
        {
            if(hit.transform.CompareTag("Player") && canShoot)
            {
                Debug.Log("Colisión con Player");
                Instantiate(bullet, shootPoint.transform.position, bullet.transform.rotation);
                ani.SetTrigger("arrow");
                Invoke("delayShoot", 1f);
                canShoot = false;
                
            }
        }
    }
    
    void delayShoot()
    {
        canShoot = true;
    }
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Vector3 direction = shootPoint.transform.TransformDirection(Vector3.forward) * rayDistance;
        Gizmos.DrawLine(shootPoint.position, direction);
    }
}
