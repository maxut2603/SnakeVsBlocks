using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SnakeMove : MonoBehaviour
{
    public float Speed;
    public List<GameObject> SnakeHealth = new List<GameObject>();
    public float offset = 0.25f;
    private Vector3 _previousMousePosition;
    public float sensitivity;
    public Transform Snake;
    public GameObject HeadPrefab;
    public GameObject BodyPrefab;
    public Camera Camera;

    private void Start()
    {
        SnakeHealth.Add(HeadPrefab);
        
    }


    private void Update()
    {
        transform.Translate(Vector3.left*Speed*Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
         //   if (Snake.position = )
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Snake.Translate(0, 0, delta.x * sensitivity * Time.deltaTime);
        }
        _previousMousePosition = Input.mousePosition;
    }

    public void AddBody()
    {
        Vector3 newBodyPos = SnakeHealth[SnakeHealth.Count-1].transform.position;
        newBodyPos.x += offset;

        SnakeHealth.Add(GameObject.Instantiate(BodyPrefab, newBodyPos, Quaternion.identity) as GameObject);
    }
}
