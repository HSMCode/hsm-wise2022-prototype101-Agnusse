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
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);

            // destroy Roboter after 1 second
            Destroy(gameObject, 1);   
        }
    }
}
