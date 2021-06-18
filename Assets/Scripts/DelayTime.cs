using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayTime : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayCoroutine());
    }


    IEnumerator DelayCoroutine()
    {
        var x = 10;
        while (x > 0)
        {
            Debug.Log(x);
            yield return new WaitForSeconds(1);
            x--;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
