using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    //Variables
    public int diceNumber;
    
    //winning numbers
    public int firstWin = 1;
    public int secondWin = 3;
    public int thirdWin = 6;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            diceNumber = Random.Range(1, 7);
            Debug.Log("Dice Number: " + diceNumber);
            
            if (diceNumber == firstWin ) {
                Debug.Log ( "You won with the lucky number  "  + firstWin);
            }
            else if (diceNumber == secondWin){
                Debug.Log ( "You won with the lucky number  " + secondWin);
            }
            else if (diceNumber == thirdWin){
                Debug.Log ( "You won with the lucky number  " + thirdWin);
            }
            else {
                Debug.Log ("You lost");
            }
        }
        
    }
}
