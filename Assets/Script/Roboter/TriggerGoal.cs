using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    public GameObject Roboter;

    AudioSource audioData;
    
    private void OnTriggerEnter (Collider other)
    {
        Debug.Log (other.name + " just hit " + gameObject.name);

        if(other.name == Roboter.name)
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");
            
            // when roboter collides with goal
            Debug.Log("Victory!!!!");


            

        }

  
    }
}
