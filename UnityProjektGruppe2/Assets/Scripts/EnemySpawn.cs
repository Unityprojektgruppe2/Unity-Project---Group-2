using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour
{

    public GameObject box;
    private float time;
    private List<GameObject> objPool;





    void Start()
    {
        objPool = new List<GameObject>();
        BoxSpawn();
    }

    private void BoxSpawn()
    {

        for (int i = 0; i < 2; i++)
        {
            GameObject newBox = Instantiate(box) as GameObject;
            newBox.SetActive(false);
            objPool.Add(newBox);
        }
    }

    void AvailableObject()
    {
        bool spawned = false;

        for (int i = 0; i < objPool.Count; i++)
        {

            if (!objPool[i].activeInHierarchy)
            {
                objPool[i].SetActive(true);
                objPool[i].transform.position = new Vector3(0, 50, 0);
                spawned = true;
                break;
            }
        }

        if (!spawned)
        {

            GameObject newBox = Instantiate(box) as GameObject;
            newBox.transform.position = new Vector3(0, 50, 0);
            objPool.Add(newBox);

        }

    }

    private void CountDown()
    {
        if (time <= 0)
        {
            AvailableObject();
            time = 1;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }


    // Update is called once per frame
    void Update()
    {
        CountDown();
    }
}
