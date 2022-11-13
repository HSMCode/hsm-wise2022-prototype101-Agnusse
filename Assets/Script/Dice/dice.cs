using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
   //Audio
    AudioSource audioData;
    
    //Variables
    public int diceNumber;
    public int [] luckyNumbers ={1,10,11,21,22,31,33,44};

    // Update is called once per frame
    void Update()
    {
        //press space to throw dice
        if (Input.GetKeyDown("space")) {
            diceNumber = Random.Range(1, 51);

            Debug.Log ("Dice number " + diceNumber); 

            //check again until i=0; so all of the numbers in the array
            for (int i = 0; i < luckyNumbers.Length ; i++)
            {
            // then do this
              // if lucky number is drawn
              if (diceNumber == luckyNumbers[i])  {
                 Debug.Log ( " Congratulations!!! You won with the lucky number  "  + diceNumber + " in loop " + i);
                 // play audio
                 audioData = GetComponent<AudioSource>();
                 audioData.Play(0);

              }
              //otherwise you lost
              else {
                  Debug.Log ("Sorry! You lost with the number " + diceNumber + " in loop " + i);
              }
            }
        }
    }
}
