using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Swiper : MonoBehaviour
{

    public float moveForce = 5, boostMultiplier = 2;

    Rigidbody2D rb;
    Touch touch1;
    Touch touch2;
    private Vector3 pos;
   
    
   // bool leftright = true, rightleft = true;
   
    // Use this for initialization
    void Start()
    {
        Handheld.Vibrate();
        rb = this.GetComponent<Rigidbody2D>();
        Input.multiTouchEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        int tapC = Input.touchCount;
        Debug.Log(tapC);
        if (Input.touches.Length < 3)
        {

            //rb.AddForce (0, 5, 0);
            for (int i = 0; i < Input.touchCount; i++)
            {
                
                //pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 5));

                //if(leftright)
                //{
                //    Vector2 moveVec =Vector2.left * moveForce * Time.deltaTime;
                //}
                //else
                //{
                //    rightleft = true;
                //}
                //if(rightleft)
                //{
                //    Vector2 moveVec = Vector2.right * moveForce * Time.deltaTime;
                //}
                //else
                //{
                //    rightleft
                //}
                Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
                bool isBoosting = CrossPlatformInputManager.GetButton("Boost");

                Debug.Log(moveVec);

                Debug.Log(isBoosting.ToString());
                rb.AddForce(moveVec);
                //transform.position = new Vector3(pos.x, pos.y, pos.z);
                
                   // rb.constraints = RigidbodyConstraints2D.None; Removes any freezing of axes.
                

            }

        }
       

    }
    public void CollideWithEnemy(Collider2D other)
    {
      

    }
    
}

