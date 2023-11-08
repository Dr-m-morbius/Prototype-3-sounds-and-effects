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
    public ParticleSystem explosion;
    public ParticleSystem dirt;
    public AudioClip jump;
    public AudioClip crash;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
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
            dirt.Stop();
            playerAudio.PlayOneShot(jump, 1.0f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("ground"))
        {
            IsOnGround = true;
            dirt.Play();
        } else if (collision.gameObject.CompareTag("obsticle"))
        {
            gameover = true;
            Debug.Log("game over");
            _playeranim.SetBool("Death_b", true);
            _playeranim.SetInteger("DeathType_int", 1);
            explosion.Play();
            dirt.Stop();
            playerAudio.PlayOneShot(crash, 1.0f);
        }
    }
}