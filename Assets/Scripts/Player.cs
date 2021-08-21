using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public CircleCollider2D cc;
    
    private float movement_speed;
    private float jump_force;
    private int max_jump, jump_count;
    
    // Start is called before the first frame update
    void Start()
    {
        movement_speed = 5f;
        jump_force = 5;
        max_jump = 2;
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FixedUpdate();
    }

    private void FixedUpdate(){
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.up * jump_force;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ) {
            // rb.velocity = -1 * Vector2.right * movement_speed;
            transform.Translate ((transform.up*Input.GetAxisRaw("Vertical") + transform.right*Input.GetAxisRaw("Horizontal")).normalized *movement_speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) ) {
            //rb.velocity = Vector2.right * movement_speed;
            transform.Translate ((transform.up*Input.GetAxisRaw("Vertical") + transform.right*Input.GetAxisRaw("Horizontal")).normalized *movement_speed*Time.deltaTime);
        }
    }
}
