using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb
{
    public GameObject Prefab;
    public bool IsGrey;

    public Bomb (GameObject obj, int coinflip)
    {
        Prefab = obj;
        IsGrey = coinflip == 1;
    }
}
