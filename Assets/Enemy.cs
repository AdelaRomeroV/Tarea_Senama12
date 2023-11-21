using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private SpriteRenderer enemy;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        enemy = GetComponent<SpriteRenderer>();
                
    }

    // Update is called once per frame

    IEnumerator Daño()
    {
        while(true) 
        {
            enemy.color = Color.white;
            //yield return new WhaiForSeconds(2);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag ("Player"))
        {
            StartCoroutine(Daño());
        }

    }
}
