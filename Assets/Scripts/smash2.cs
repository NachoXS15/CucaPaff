using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash2 : MonoBehaviour
{
    public GameObject smashEffect;
    public static bool isDestroyed = false;
    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.transform.tag == "Enemy"){
            Destroy(gameObject);
            Instantiate(smashEffect, transform.position, Quaternion.identity);
            isDestroyed = true;
            playerManager.isGameOver = true;
            Debug.Log("destroyed");
        }
    }
}
