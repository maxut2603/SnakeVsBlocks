using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGen : MonoBehaviour
{
    public GameObject HeadPrefab;
    public GameObject BlocksPrefab;
    public int maxBlocks;
    public int minBlocks;
    public int DistanceBetweenBlocks;
    float[] zPozitionBlock = { -2.6f, -1.6f, -0.6f, 0.4f, 1.4f, 2.4f };
    public Transform RoadRoot;

    void Awake()
    {
        Instantiate(HeadPrefab, new Vector3(0, 0.25f, 0), Quaternion.Euler(0, 0, 0));
        int blocksCount = Random.Range(minBlocks, maxBlocks + 1);

        for (int i = 0; i < blocksCount; i++)
        {
            int blocksLine = Random.Range(2, 5);
            float[] zPoz = zPozitionBlock.OrderBy(x => Random.value).ToArray();
            Array.Resize(ref zPoz, blocksLine);
            for (int j = 0; j < zPoz.Length; j++)
            {
                Vector3 _blocksGen = new Vector3(-DistanceBetweenBlocks * i, 0.5f, zPoz[j]);
                Instantiate(BlocksPrefab, _blocksGen, Quaternion.Euler(0, 0, 0));
            }
            
        }

        RoadRoot.localScale = new Vector3(DistanceBetweenBlocks + blocksCount, 1, 1);
        
    }

    
}
