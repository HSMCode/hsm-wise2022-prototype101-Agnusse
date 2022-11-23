using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoy : MonoBehaviour
{

    public GameObject Decoy; 
    public float spawnPositionX = 10f;
    public float spawnPositionZ = 10f;
    public int spawnAmount= 10;

    public float startDelay = 0f;
    public float spawnInterval=7f;


    // Start is called before the first frame update
    void Start()
    {
        SpawningDecoyParam(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawningDecoyParam(int amount)
    {
        for (int i = 0; i< amount; i++)
            {
            // generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3 (Mathf.Round(Random.Range(-spawnPositionX,spawnPositionX)),0,Mathf.Round(Random.Range(-spawnPositionZ,spawnPositionZ)));
            
            // instantiate decoy
            Instantiate (Decoy, spawnPosition, transform.rotation);
            }
    }
}
