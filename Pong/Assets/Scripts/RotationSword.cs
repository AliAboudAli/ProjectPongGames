using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float rotz;
    public float rotationSpeed;
    public bool ClockwiseRotation;

    void Update()
    {
        if (ClockwiseRotation == false)
        {
            rotz += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotz += -Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotz);
    }
}
