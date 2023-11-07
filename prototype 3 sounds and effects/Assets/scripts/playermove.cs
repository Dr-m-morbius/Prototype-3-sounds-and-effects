using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float JumpForce = 10f;
    public float Gravity = 1f;
    public bool gameover = false;
    public bool IsOnGround = true;
    private Rigidbody _playerRb;
    private Animator _playeranim;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playeranim = GetComponent<Animator>();
        //_playerRb.AddForce(Vector3.up * 1000);
        Physics.gravity *= Gravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround && !gameover) 
        {
            _playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnGround = false;
            _playeranim.SetTrigger("Jump_trig");
           
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("ground"))
        {
            IsOnGround = true;
        } else if (collision.gameObject.CompareTag("obsticle"))
        {
            gameover = true;
            Debug.Log("game over");
            _playeranim.SetBool("Death_b", true);
            _playeranim.SetInteger("DeathType_int", 1);
        }
    }
}