using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemy; //reference to itself
    public float moveSpeed = 15.0f;
    public bool changeDirection = false;


    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy(); 
    }

    public void moveEnemy()
    {
        if (changeDirection == true)
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed; 
        }else if (changeDirection == false)
        {
            enemy.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       if(col.gameObject.name == "RightWall")
        {
            Debug.Log("Hit the right wall");
            changeDirection = true;
        }
       if(col.gameObject.name == "LeftWall")
        {
            Debug.Log("Hit the left wall");
            changeDirection = false;
        }

    }



}
