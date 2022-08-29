using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody rb;
    public Animator ani;
    public Transform eje;
    public RaycastHit hit;
    public Vector3 v3;
    public bool inground;
    public float TransLayers;
    public float speed;
    public float jumpSpeed;
    public float distance;

    void Move()
    {
        Vector3 RotaTargetZ = eje.transform.forward;
        RotaTargetZ.y = 0;
    

    if (Input.GetKey(KeyCode.W))
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(RotaTargetZ), 0.3f);
        var dir = transform.forward * speed * Time.fixedDeltaTime;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
        ani.SetBool("run", true);
    }
    else
    {
        if (inground)
        {
            rb.velocity = Vector3.zero;
        }
        ani.SetBool("run", false);
    }

    if (Input.GetKey(KeyCode.S))
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(RotaTargetZ* -1), 0.3f);
        var dir = transform.forward * speed * Time.fixedDeltaTime;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
        ani.SetBool("run", true);
    }

    Vector3 RotaTargetX = eje.transform.right;
    RotaTargetX.y = 0;

    if (Input.GetKey(KeyCode.D))
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(RotaTargetX), 0.3f);
        var dir = transform.forward * speed * Time.fixedDeltaTime;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
        ani.SetBool("run", true);
    }

    if (Input.GetKey(KeyCode.A))
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(RotaTargetX* -1), 0.3f);
        var dir = transform.forward * speed * Time.fixedDeltaTime;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
        ani.SetBool("run", true);
    }
    }
    
    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position + v3, transform.up * -1, out hit, distance))
        {
            if (hit.collider.tag == "piso")
            {
                inground = true;
            }
        }
        else
        {
            inground = false;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 3;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 3;
        }

    }
    
    









}
