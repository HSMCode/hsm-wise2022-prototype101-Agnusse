using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Roboter;

    AudioSource audioData;

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log (other.name + " just hit " + gameObject.name);

        if(other.name == Roboter.name)
        {
            // when roboter collides with decoy
            Debug.Log("Decoy was hit");

            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Debug.Log("started");

            Destroy(gameObject, 1);
            
        }
    }
}
