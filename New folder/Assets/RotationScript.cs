using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    Transform pivotPoint;
    public float speed = 1f;
    public bool switchRotate ;

    void Start()
    {
        pivotPoint = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            switchRotate = !switchRotate;
        }
        rotation(switchRotate, speed);
    }

    public void rotation(bool Switch, float speed)
    {
        float changeRotation = 90;
        if (Switch)
        {
           changeRotation = -90f;
        }
        else
        {
            changeRotation = 90f;
        }

        pivotPoint.Rotate(0f, 0f, changeRotation * speed * Time.deltaTime);

    }
}
