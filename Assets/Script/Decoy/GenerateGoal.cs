using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGoal : MonoBehaviour
{

    void Start()
     {
        transform.Translate(Random.Range(-10, 10),0,Random.Range(-10,10));
     } 
}