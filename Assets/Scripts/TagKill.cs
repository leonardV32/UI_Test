using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TagKill : MonoBehaviour
{
    private SpaceControls controls;
    private void OnEnable()
    {
        controls = new SpaceControls();
        controls.Enable();
        controls.Main.Appear.performed += AppearOnperformed;
    }
    
    private void AppearOnperformed(InputAction.CallbackContext obj)
    {
        var toKill = GameObject.FindGameObjectsWithTag("KillMe");

        foreach (var prefab in toKill)
        {
            Destroy(prefab);
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
