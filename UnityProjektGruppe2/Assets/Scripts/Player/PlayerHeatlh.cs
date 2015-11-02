using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerHeatlh : MonoBehaviour
{

    #region Variables
    private bool isAlive = true;
    public static int maxHealth = 100;
    public float currentHealth = 100;
    public float timesMaxHealth = 0.1f;

    GameObject enemy;
    EnemyAttack enemyAttack;

    #endregion

    #region methods

    #region Awake method
    //sets the variables and find tag.
    void awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyAttack = enemy.GetComponent <EnemyAttack> ();
    }
    #endregion

    #region Take damage method

    //If method is run, takes integer amount as damage from other script

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }
    #endregion

    #region Trigger method
    //If collider is entered by other, trigger if sentence.

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUpHealth")
        {
            currentHealth += (maxHealth * timesMaxHealth);
        }

    }

    #endregion

    #region Death
    //destroys gameobject if health is below certain number.

    public void Death()
    {
        if (currentHealth <= 0 || !isAlive)
        {
            Destroy(this.gameObject);
            GameOver();
        }
    }
    #endregion

    #region Gameover (empty script)
    public void GameOver()
    {

    }

    #endregion

    #region Update
    // Update is called once per frame
    void Update ()
    {
        Death();
	}
    #endregion


    #endregion

}
