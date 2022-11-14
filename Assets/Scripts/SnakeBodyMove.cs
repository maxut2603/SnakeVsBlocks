using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyMove : MonoBehaviour
{
    private float _speed;
    public Vector3 bodyTarget;
    public SnakeMove snakehead;
    public GameObject BodyTargetOdj;
    private void Start()
    {
        
        snakehead = GameObject.FindGameObjectWithTag("SnakeHead").GetComponent<SnakeMove>();
        _speed = snakehead.Speed + 2;
        BodyTargetOdj = snakehead.SnakeHealth[snakehead.SnakeHealth.Count - 2];
    }
    private void Update()
    {
        bodyTarget = BodyTargetOdj.transform.position;
        transform.LookAt(bodyTarget);
        transform.position = Vector3.Lerp(transform.position, bodyTarget, Time.deltaTime * _speed);
    }

}
