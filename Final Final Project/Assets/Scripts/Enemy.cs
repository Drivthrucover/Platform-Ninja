using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    Vector3 startingPosition;
    float direction;
    [SerializeField]float maxMovementDistance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        

        if (currentPosition.x <= startingPosition.x)
        {
            direction = 1f;
        }

        else if (currentPosition.x >= startingPosition.x + maxMovementDistance)
        {
            direction = -1f;
        }

        myRigidBody.velocity = new Vector2(direction, 0);
    }

    
}
