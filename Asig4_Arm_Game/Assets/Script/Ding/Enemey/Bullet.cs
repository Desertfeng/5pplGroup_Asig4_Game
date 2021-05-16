using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("clooli");

        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Umberella"  )
        Destroy(this.gameObject);
    }
}
