using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpriteAppear : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabsToSpawn;

    [SerializeField] private GameObject ToSpawn;
    [SerializeField] private GameObject ToSpawn1;
    [SerializeField] private GameObject ToSpawn2;
    [SerializeField] private GameObject ToSpawn3;
    [SerializeField] private GameObject ToSpawn4;

    private SpaceControls controls;
    
    private void OnEnable()
    {
        controls = new SpaceControls();
        controls.Enable();
        controls.Main.Appear.performed += AppearOnperformed;
    }


    private void AppearOnperformed(InputAction.CallbackContext obj)
    {
        FirstIteration();
    }

    private void FirstIteration()
    {
        var pos = Vector3.zero;
        foreach (var prefab in prefabsToSpawn)
        {
            Instantiate(prefab, pos, Quaternion.identity);
            pos.x++;
        }
    }

    private void SecondIteration()
    {
        var i = 0;
        var pos = Vector3.zero;
        while (i < prefabsToSpawn.Length)
        {
            pos.x = i;
            Instantiate(prefabsToSpawn[i], pos, Quaternion.identity);
            i++;
        }
    }


    private void ThirdIteration()
    {
        var pos = Vector3.zero;
        for (var i = 0; i < prefabsToSpawn.Length; i++)
        {
            pos.x = i;
            Instantiate(prefabsToSpawn[i], pos, Quaternion.identity);
        }
    }
    /*private void AppearOnperformed(InputAction.CallbackContext obj)
    {
        var pos = Vector3.zero;
        Instantiate(ToSpawn, pos, Quaternion.identity);
        pos.x++;
        Instantiate(ToSpawn1, pos, Quaternion.identity);
        pos.x++;
        Instantiate(ToSpawn2, pos, Quaternion.identity);
        pos.x++;
        Instantiate(ToSpawn3, pos, Quaternion.identity);
        pos.x++;
        Instantiate(ToSpawn4, pos, Quaternion.identity);
        pos.x++;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
