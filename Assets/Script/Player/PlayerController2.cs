using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    public GameObject Ground;

    public float horizontalInput;
    public float forwardInput;
    public float speed = 10;
    public float turnSpeed = 200;
    public float gravityScale;
    public bool isInTheAir = false;
    public bool isFalling = false;

    public Vector3 force;

    private Animator _playerAnim;
    private Rigidbody _playerRb;





    //



    // public bool jumpCancelled;
    // public float jumpTimer;
    // public float jumpButtonPressedTime;



    //






    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);


        _playerAnim.SetFloat("Run", forwardInput);

        if (forwardInput != 0 || horizontalInput != 0){
            if (!isInTheAir){
                _playerAnim.SetBool("Walk", true);
            }
        }else {
            _playerAnim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            if (!isInTheAir){
                _playerRb.AddForce(force, ForceMode.Impulse);
                _playerAnim.SetTrigger("Jump");
                isInTheAir = true;
            }
        }

        //
  




        
        // if (isJumping)
        // {
        //     jumpTimer += Time.deltaTime;
        //     if(Input.GetKeyup(Keycode.Space))
        //     {
        //         jumpCancelled = true;

        //         isJumping = false;
        //         isFalling = true;
        //     }
        //     if( jumpTimer > jumpButtonPressedTime)
        //     {
        //         isJumping = false;
        //     }
        // }
        






        //


        if (isInTheAir && _playerRb.velocity.y < 0 && !isFalling){
            isFalling = true;
            Debug.Log("Falling == true");
            _playerAnim.SetTrigger("TriggerFalling");
        }
        
    }

    void FixedUpdate(){
        // Debug.Log(_playerRb.velocity.y);
    }

    // private void OnTriggerEnter(Collider other){

    //     if(other.name == Ground.name){
    //         isJumping = false;
    //     }
        
    // }

    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.CompareTag("Ground")){
            isInTheAir = false;
            isFalling = false;
            _playerAnim.SetBool("Falling", false);
        }
        
    }
}