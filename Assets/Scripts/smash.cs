using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash : MonoBehaviour
{
    [SerializeField] public GameObject smashEffect;
    void OnMouseDown(){
        
        Destroy(gameObject);
        Instantiate(smashEffect, transform.position, Quaternion.identity);
    }
}
