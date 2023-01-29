using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboterscript : MonoBehaviour
{

    public float step= 1f;
    

    public float roStep= 90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
          transform.Translate (0,0,step);

        }

        if(Input.GetKeyDown("s"))
        {
          transform.Translate (0,0,-step);
        
        }
        if(Input.GetKeyDown("d"))
        {
          transform.Translate (step,0,0);
        
        }
        if(Input.GetKeyDown("a"))
        {
          transform.Translate (-step,0,0);
        
        }

        //rotate on the y-axis 
        if(Input.GetKeyDown("q"))
        {
          //rotate roboter left
          transform.Rotate (0,-roStep,0);
        }

        //rotate on the y-axis 
        
        if(Input.GetKeyDown("e"))
        {
          //rotate roboter left
          transform.Rotate (0,roStep,0);
        }
    }
}
