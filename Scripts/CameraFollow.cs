using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform target;
    void Start()
    {
        target = GameObject.Find("Bird1").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y = target.position.y-0.65f;
        transform.position = temp;
    }
}
