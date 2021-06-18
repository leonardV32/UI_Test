using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minefield : MonoBehaviour
{
    [SerializeField] private int lineSizeX, lineSizeY;
    [SerializeField] private GameObject[] prefabs;

    private Bomb[,] bombs;

    // Start is called before the first frame update
    void Start()
    {
        bombs = new Bomb [lineSizeX, lineSizeY];
        var pos = Vector3.zero;

        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                bombs[i, j] = new Bomb(prefabs[Random.Range(0, prefabs.Length)], Random.Range(0, 2));
            }
        }

        for (var i = 1; i < lineSizeX - 1; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                if (bombs[i - 1, j].Prefab == bombs[i + 1, j].Prefab)
                {
                    bombs[i, j].Prefab = bombs[i - 1, j].Prefab;
                }
            }
        }

        for (var i = 0; i < lineSizeX; i++)
        {
            for (var j = 0; j < lineSizeY; j++)
            {
                pos.x = i;
                pos.y = j;
                //Instantiate(bombs[i, j].Prefab, pos, Quaternion.identity);
                var instance = Instantiate(bombs[i, j].Prefab, pos, Quaternion.identity);
                if (bombs[i, j].IsGrey)
                {
                    instance.GetComponent<SpriteRenderer>().color = Color.grey;
                }
            }
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
