using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class movethingy : MonoBehaviour
{
    private float speed = 30f;
    private playermove PlayerControllerScript;
    private float leftbound = -15;
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

        if (transform.position.x < leftbound && gameObject.CompareTag("obsticle"))
        {
            Destroy(gameObject);
        }
    }
}
