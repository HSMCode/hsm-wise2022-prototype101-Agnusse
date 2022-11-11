using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    //Variables
    public int diceNumber;
    
    // winning numbers
    // public int firstWin = 1;
    // public int secondWin = 3;
    // public int thirdWin = 6;


    public int [] luckyNumbers ={ 1,3,6};


    // public int [] luckyNumbers= new int [3];
    // Start is called before the first frame update
    void Start()
    {
    //    luckyNumbers[0] = 1;
    //    luckyNumbers[1] = 3;
    //    luckyNummbers[2] = 6;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")) {
            diceNumber = Random.Range(1, 7);

        Debug.Log ("Dice number " + diceNumber); 


          for (int i = 0; i < luckyNumbers.Length ; i++)
            {
            // do this
            Debug.Log("for loop: " + i);
            

            if (diceNumber == luckyNumbers[i])  {
                Debug.Log ( "You won with the lucky number  "  + diceNumber);

             }
             else {
                Debug.Log ("You lost");
              }
            }
            
            

            // if (diceNumber == luckyNumbers[0] || diceNumber == luckyNumbers[1] || diceNumber ==luckyNumbers[2] ) {
            //     Debug.Log ( "You won with the lucky number  "  + diceNumber);
            // }
            // else if (diceNumber == secondWin){
            //     Debug.Log ( "You won with the lucky number  " + secondWin);
            // }
            // else if (diceNumber == thirdWin){
            //     Debug.Log ( "You won with the lucky number  " + thirdWin);
            // }
            
            // else {
            //     Debug.Log ("You lost");
            //   }
        
           }
    }
}
