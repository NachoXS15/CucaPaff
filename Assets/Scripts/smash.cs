using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash : MonoBehaviour
{
    public GameObject smashEffect;
    void OnMouseDown(){
        Destroy(gameObject);
        Instantiate(smashEffect, transform.position, Quaternion.identity);
    }
}
