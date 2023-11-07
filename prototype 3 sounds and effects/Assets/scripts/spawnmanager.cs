using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject obstacle;
    private Vector3 spawnPosition = new Vector3(25, 0,0);
    private float startdelsy = 2;
    private float
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
