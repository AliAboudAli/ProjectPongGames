using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber = 0;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 0)
        {
            transform.Translate(0, Input.GetAxis("PLeftMove") * moveSpeed *
                Time.deltaTime, 0);
        }
        if (playerNumber == 1)
        {
            transform.Translate(0, Input.GetAxis("PRightMove") * moveSpeed *
                Time.deltaTime, 0);
        }
        
    }
}
