using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

    public float moveForce = 5, boostMultiplier = 2;

    Rigidbody myRigidBody;

    // Use this for initialization
    void Start()
    {
        myRigidBody = this.GetComponent<Rigidbody>();
        Input.multiTouchEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"),0, CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        bool isBoosting = CrossPlatformInputManager.GetButton("LeButton");

        //Debug.Log(moveVec);
        //Debug.Log(isBoosting.ToString());
        Debug.Log(transform.position);

        myRigidBody.AddForce(moveVec * (isBoosting ? boostMultiplier : 1));
    }




    public void CollideWithEnemy(Collider2D other)
    {


    }

}
