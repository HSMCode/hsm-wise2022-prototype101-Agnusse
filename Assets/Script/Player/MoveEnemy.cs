using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private Rigidbody _enemyRb;
    private GameObject _player;

    [SerializeField] float speed;

    private EnemiesCounter _enemiesDestroyedCounter;

    
    void Start()
    {
        _enemyRb = GetComponent<Rigidbody>();
        
        // make sure to set the tag "Player" on your player character for this to work
        _player = GameObject.FindWithTag("Player");


        // GameObject sCRIPT ADD COUNTER
        _enemiesDestroyedCounter = GameObject.Find("EnemiesDestroyedCounter").GetComponent<EnemiesCounter>();
    }
    
    void FixedUpdate()
    {
        // move the enemy to the vector position of the player
        _enemyRb.AddForce((_player.transform.position - transform.position).normalized * speed);
        // Debug.Log("Player: " + _player.transform.position + "Enemy: " + transform.position);
    }
    
    
    // For debugging we can add gizmos to help visualise depth and distance a bit better
    void OnDrawGizmosSelected()
    {
        if (_player != null)
        {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, _player.transform.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            _enemiesDestroyedCounter.addOne();
        }
    }
}