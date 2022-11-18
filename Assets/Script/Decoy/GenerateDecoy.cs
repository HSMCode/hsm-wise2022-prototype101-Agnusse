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
        //SpawningDecoy();
        // InvokeRepeating("SpawningDecoy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("space"))
        {
            SpawningDecoyParam(5);

            // for (int i = 0; i< spawnAmount; i++)
            // {
            // Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));

            // Instantiate (Decoy, spawnPosition, transform.rotation);
            // }
        }
    }
    public void SpawningDecoyParam(int amount)
    {
        for (int i = 0; i< amount; i++)
            {
            // generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));
            
            // instantiate decoy
            Instantiate (Decoy, spawnPosition, transform.rotation);
            }
    }
}
