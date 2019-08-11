using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed;

    Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
      float controlThrow = Input.GetAxis("Horizontal");  // value is between -1 to +1
      Vector3 playerVelocity = new Vector3(controlThrow * runSpeed, myRigidBody.velocity.y, myRigidBody.velocity.z);
      myRigidBody.velocity = playerVelocity;
    }
}
