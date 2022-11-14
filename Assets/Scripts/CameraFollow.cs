using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform head;
    public Vector3 CameraOffset;
    private void Start()
    {
        head = GameObject.FindGameObjectWithTag("SnakeHead").transform;
    }
    void Update()
    {
        //transform.LookAt(head);
        Vector3 position = transform.position;
        position.x = head.position.x+3;
        transform.position = position;
    }
}
