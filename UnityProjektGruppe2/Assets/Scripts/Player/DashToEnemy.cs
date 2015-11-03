using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class DashToEnemy : MonoBehaviour
{

    public GameObject EnemyTarget;
    public GameObject button;
    public bool EnemyT;
    public GameObject player;
    //public static Vector3 dash;
    Vector3 maxDistance;
    //int LayerMask = 1 << 8;
    LayerMask mask;
    RaycastHit hit;
    public int playerAttack = 10;
    EnemyHealth enemyHealth;
    
    public float distanceToObstacle;
    
    CharacterController charCtrl;

  
    void Awake ()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        //player = GameObject.FindGameObjectWithTag("Player");
    }
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dash = new Vector3(EnemyTarget.transform.position.x, EnemyTarget.transform.position.y);
        //distanceToObstacle = 0;
        // maxDistance = player.transform.position * 3;
    }
    public void dashToEnemy()
    {
        
        EnemyT = true;
        if (EnemyT)
        {
            if (button.tag == "UP")
            {

                //mangler funktionalitet til at stun' enemy.
                Debug.Log("hej");
                //bool DashActivated = CrossPlatformInputManager.GetButton("UP");

                player.transform.position = new Vector3(EnemyTarget.transform.position.x, EnemyTarget.transform.position.y);
                EnemyT = false;

                if (player.transform.position.x == EnemyTarget.transform.position.x && player.transform.position.y == EnemyTarget.transform.position.y)
                {
                    enemyHealth.currentHealth -= playerAttack;
                    Debug.Log(enemyHealth.currentHealth);
                }
            }
        }
    }

    
}
