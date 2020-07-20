using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    LifeKeeper theLifeKeeper;

    Collider2D myCollider;
    Rigidbody2D myRigidBody;
    [SerializeField]float runSpeed = 5f;
    [SerializeField]float jumpSpeed = 5f;


   

    //public Vector2 startingPoint; 
    

    


    // Start is called before the first frame update
    void Start()
    {
        
        theLifeKeeper = FindObjectOfType<LifeKeeper>();
        //startingPoint = gameObject.transform.position;
        myCollider = GetComponent<Collider2D>();
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }

    private void Run()
    {
        float controlDirection = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlDirection * runSpeed,
            myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }

    private void Jump()
    {

        if (!myCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }

        if(Input.GetButtonDown("Jump"))
        {
            Vector2 JumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            myRigidBody.velocity += JumpVelocityToAdd;
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            theLifeKeeper.DecreaseLives();
            Destroy(gameObject);
        }
        
        if (collision.tag == "spikes")
        {
            theLifeKeeper.DecreaseLives();
            Destroy(gameObject);
        }
    }

    





}
