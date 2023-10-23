using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float JumpForce = 10f;
    public float Gravity = 1f;
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
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround) 
        {
            _playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnGround = false;
            _playeranim
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        IsOnGround = true;
    }
}
