using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnLeft;
    public Transform spawnRight;
    public GameObject Enemy;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnEnemy", 0f , delay );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        int randNum = Random.Range(1,4); // 1 or 2 or 3
        if (randNum == 1)
        {
            Instantiate(Enemy,spawnLeft);
        }
        else if(randNum == 2)
        {
            Instantiate(Enemy,spawn);
        }
        else
        {
            Instantiate(Enemy,spawnRight);
        }
     
    }
}
