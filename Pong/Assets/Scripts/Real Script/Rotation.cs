using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 startRotation;

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = startRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
