using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethingy : MonoBehaviour
{
    private float speed = 30f;
    private playermove PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
       PlayerControllerScript = GameObject.Find("player"). GetComponent<playermove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameover == false)
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
