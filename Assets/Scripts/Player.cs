using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed;

    Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
      float controlThrow = GetAxis("Horizontal");  // value is between -1 to +1
      Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
      myRigidBody.velocity = playerVelocity;
    }
}
