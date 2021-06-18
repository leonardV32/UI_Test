using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeGrav : MonoBehaviour
{
    

    [SerializeField] private float speed;
    [SerializeField] private float maxspeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform RaycastStartTransform;
    [SerializeField] private LayerMask AllProp;

    private ExoGrav controls;

    private Rigidbody2D rb2D;

    private float direction;

    private Vector2 trait;

    //private bool canJump = false;

    private void OnEnable()
    {
        controls = new ExoGrav();
        controls.Enable();
        controls.Main.Move.performed += MoveOnperformed;
        controls.Main.Move.canceled += MoveOncanceled;
        controls.Main.GravChange.performed += GravChangeOnperformed;
        controls.Main.Jump.performed += JumpOnperformed;
    }



    private void MoveOnperformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
    }

    private void MoveOncanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
    }
    private void GravChangeOnperformed(InputAction.CallbackContext obj)
    {
        var floor = obj.ReadValue<Vector2>();

        Physics2D.gravity = (floor * 9.81f);

        transform.up = -floor;

        /*if ( floor == new Vector2 (1,0)) //right
        {
            Physics2D.gravity = new Vector2(9.8f, 0);
        }
        else if (floor == new Vector2(-1, 0)) //left
        {
            Physics2D.gravity = new Vector2(-9.8f, 0);
        }
        else if (floor == new Vector2(0, 1)) //up
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
        }
        else //down new Vector2 (0,-1)
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
        }*/
    }

    private void JumpOnperformed(InputAction.CallbackContext obj)
    {
        var hit = Physics2D.Raycast(RaycastStartTransform.position, trait, 0.1f, AllProp);  //créer un raycast sur gameobject vide

        if (hit == true)
        {
            rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        
       
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
        rb2D = GetComponent<Rigidbody2D>();
        trait = Vector2.down;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(transform.right * speed * direction);
        }

    }
}
