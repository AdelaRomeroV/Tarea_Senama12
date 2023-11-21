using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movimiento")]
    private Rigidbody2D rb2D;
    private Vector2 playerInput;
    public float movSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + playerInput * movSpeed * Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        Mov();
    }

    void Mov()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        playerInput = new Vector2(moveX, moveY).normalized;
    }
}
