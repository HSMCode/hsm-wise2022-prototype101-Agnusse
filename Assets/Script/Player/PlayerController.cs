using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed;
    public float turnSpeed;
    public float force;
    public float forceDown;
    public float gravityModifier;
    public bool isJumping;
    public bool isFalling;

    public bool isOnGround = false;

    private Animator _playerAnim;
    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //move and rotate Player
        horizontalInput= Input.GetAxis("Horizontal");
        forwardInput= Input.GetAxis("Vertical");

        transform.Translate (Vector3.forward * forwardInput * Time.deltaTime * speed);
        transform.Rotate (Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);

        _playerAnim.SetFloat("Run", forwardInput);

        //assign Animations
        if(forwardInput != 0  || horizontalInput != 0)
        {
            _playerAnim.SetBool("Walk", true);
        }

        else
        {
            _playerAnim.SetBool("Walk", false);
        }

        //player is jumping press space
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            isJumping = true;

            if(isJumping)
            { 
                _playerAnim.SetTrigger("Jump");
                // _playerRb.AddForce(force, ForceMode.Impulse);
            }
        }
        //release space to start falling
         if (Input.GetKeyUp(KeyCode.Space))
        {
            isFalling = true;
            isJumping = false;
            if(isFalling)
            { 
                _playerAnim.SetBool   ("Fall", true);
            }
        }
    }
    void FixedUpdate()
     {
          if(isJumping)
            { 
                _playerRb.AddForce(Vector3.up * force, ForceMode.Force);
            }

            if (isFalling || isOnGround)
            {
                _playerRb.AddForce(Vector3.down * forceDown *_playerRb.mass);
            }
     }
    
     private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag ("Ground"))
        {
            isOnGround = true; 
            if(isFalling)
            {
                _playerAnim.SetBool ("Fall", false);
                isFalling = false;
            }
        } 
    }
}
