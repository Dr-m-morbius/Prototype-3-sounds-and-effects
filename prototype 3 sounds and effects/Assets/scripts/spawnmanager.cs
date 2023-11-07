using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 spawnPosition = new Vector3(25, 0,0);
    private float startdelay = 2;
    private float repeterate = 2;
    private playermove PlayerMoveScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMoveScript = GameObject.Find("player").GetComponent<playermove>();
        InvokeRepeating("spawnobstacle", startdelay, repeterate);
    }

    // Update is called once per frame
    void spawnobstacle()
    {
       if(PlayerMoveScript.gameover == false) 
        {
            Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
        }
    }
}
