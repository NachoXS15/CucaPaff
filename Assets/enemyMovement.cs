using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    //parameters
    public Transform target;
    public float speed;


    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate(){
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }

}
