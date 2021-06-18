using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRand : MonoBehaviour
{
    [SerializeField] private int lineSize;
    [SerializeField] private GameObject[] Prefab;

    private Cellule[] cells;

    
    // Start is called before the first frame update
    void Start()
    {
        cells = new Cellule[lineSize];

        FillArray();

        ContaminateArray();

        InstantiateArray();

    }


    private void FillArray()
    {
        
        for (var i = 0; i < lineSize; i++)
        {
            var id = Random.Range(0, 5);
            cells[i] = new Cellule(id);
        }
    }


    private void ContaminateArray()
    {
        for (var i = 1; i < lineSize - 1; i++)
        {
            if (cells [i - 1].rand == cells [i + 1].rand)
            {
                cells[i].rand = cells[i + 1].rand;
            }
        }
    }


    private void InstantiateArray()
    {
        var pos = Vector3.zero;
        for (var i = 0; i < lineSize; i++)
        {
            pos.x = i;
            Instantiate(Prefab[cells[i].rand], pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
