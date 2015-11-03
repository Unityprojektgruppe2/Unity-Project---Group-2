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
        Movement();
    }

    void Movement()
    {
        Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        bool isBoosting = CrossPlatformInputManager.GetButton("LeButton");

        //Debug.Log(moveVec);
        //Debug.Log(isBoosting.ToString());
        Debug.Log(transform.position);

        myRigidBody.AddForce(moveVec * (isBoosting ? boostMultiplier : 1));
    }






    public void CollideWithEnemy(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            EnemyHealth enemyHp = other.GetComponent<EnemyHealth>();
            enemyHp.TakeDamage(10, new Vector3(0, 0, 0));

        }

    }

}
