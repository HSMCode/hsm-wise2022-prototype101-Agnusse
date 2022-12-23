using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdown : MonoBehaviour
{
    private bool _canStart;
     void Start()
    {
         _canStart = true;
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C)&& _canStart)
        {
            StartCoroutine( routine: CountingDown());
        }
        else if (Input.GetKeyDown(KeyCode.C)&& _canStart) 
        {
            Debug.Log( message:"wait for Coroutine ready to start again: ")
        }
    }


  
    //game over 
    private IEnumerator Countingdown ()
    { 
         _canStart = false;
         
         Debug.Log( message:"Waiting for seconds of countdown: " + couzntDown)
         yield return new(WaitForSeconds(3));
         Debug.Log( message:"Coroutine ready to start again: ")
         _canStart = true;
    }
}
