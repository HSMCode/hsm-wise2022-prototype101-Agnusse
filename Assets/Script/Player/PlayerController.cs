using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Ground;
    public float horizontalInput;
    public float forwardInput;
    public float speed;
    public float turnSpeed;
    public Vector3 force;
    public bool isJumping = false;

    private Animator _playerAnim;
    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody>();
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                _playerRb.AddForce(force, ForceMode.Impulse);
                _playerAnim.SetTrigger("Jump");
                isJumping = true;
            }
            
        }
    }

     private void OnTriggerEnter (Collider other)
    {
        if(other.name == Ground.name)
        {
          isJumping = false; 
        }
    }
}
