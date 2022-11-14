using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDeneration : MonoBehaviour
{
    public GameObject Food;
    public float ZSize = 2.8f;
    public Vector3 curPos;
    public GameObject curFood;
    public int XSize;

    private void Start()
    {
        FoodGen();
    }


    void FoodGen()
    {
        for (int i = 0; i < 350; i++)
        {
            XSize = -i - 4;
            RandomPos();
            curFood = GameObject.Instantiate(Food, curPos, Quaternion.identity) as GameObject;
        }

        
    }

    void RandomPos()
    {
        curPos = new Vector3(XSize, 0.1f, Random.Range(-ZSize, ZSize));
    }

  
}
