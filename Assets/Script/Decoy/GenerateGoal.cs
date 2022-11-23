using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGoal : MonoBehaviour
{
    
    void Start()
     {
        transform.Translate(Mathf.Round(Random.Range(-10,-5 + 5, 10)),0,Mathf.Round(Random.Range(-10,-5 + 5,10)));
     } 
}