using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float moveSpeed = 20f;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        if (direction.x > -0.1f && direction.x < 0.1f)
        {
            direction = new Vector2(0.5f, direction.y);
        }
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RightBarrier"))
        {

            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("LeftBarrier"))
        {

            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
        }
    }
    public void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0);
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction = direction.normalized;

    }
    private void Increaseballspeed()
    {
        moveSpeed = moveSpeed + Time.deltaTime * 0.5f;

    }
    
}
