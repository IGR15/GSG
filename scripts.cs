using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    
     void Start()
    {
        //exercise 1
          int number;
        while (true)
        {
            
            number = Random.Range(1, 21);
            if (number == 5)
            {
                continue;
            }
            Debug.Log( number);
            if (number == 15)
            {
                Debug.Log("Number 15 found, exiting the loop.");
                break;
            }
        }

        //exercise 2
        // i did exercise 2 in two deffrent whys!!!

        //  string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird","" };
        //  string sentence = "";
        //  int wordCounter = 0;
    
        // while (wordCounter <= 7)
        // {
           
        //     int index = Random.Range(0, words.Length);
        //     string randomWord = words[index];
        //     sentence += randomWord + " ";
 
        //     wordCounter++;
        // }
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird","" };
         string sentence = "";
         int wordCounter = 0;
    
        while (wordCounter <= 7)
        {
           
            int index = Random.Range(0, words.Length);
            string randomWord = words[index];
            if (!sentence.Contains(randomWord))
            {
                
                sentence += randomWord + " ";

                
                wordCounter++;
            }
        }


        
       
       
        Debug.Log("Funny sentence: " + sentence);
    }
        

       
        
    
}
