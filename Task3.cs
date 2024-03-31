using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public bool isPlaying;

    IEnumerator Start()
    {
        isPlaying = true;

        while (isPlaying == true)
        {
            yield return new WaitForSeconds(3f);
            checkCard();
        }
    }

    string[] cardNumber =
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6"
    };

    string[] cardType =
    {
        "♣",
        "♦",
        "♥",
        "♠",
        "♣",
        "♦",
        "♥",
        "♠",
        "♣",
        "♦",
        "♥",
        "♠",
        "♣",
        "♦",
        "♥",
        "♠"
    };

    HashSet<string> matchingCards = new();
    HashSet<string> notMatchingCards = new();

    public void checkCard()
    {
        string numberCard1 = cardNumber[Random.Range(0, 15)];
        string typeOfCard1 = cardType[Random.Range(0, 15)];
        string numberCard2 = cardNumber[Random.Range(0, 15)];
        string typeOfCard2 = cardType[Random.Range(0, 15)];
        string numberCard3 = cardNumber[Random.Range(0, 15)];
        string typeOfCard3 = cardType[Random.Range(0, 15)];
        string numberCard4 = cardNumber[Random.Range(0, 15)];
        string typeOfCard4 = cardType[Random.Range(0, 15)];
        
        //Checks for win condition 1 2 3
        Debug.Log("I made the initial deck and draw. My hand is: " + numberCard1 + typeOfCard1 + ", " + numberCard2 + typeOfCard2 
        + ", " + numberCard3 + typeOfCard3 + ", " + numberCard4 + typeOfCard4);
        if (string.Compare(typeOfCard1, typeOfCard2) == 0 && string.Compare(typeOfCard2, typeOfCard3) == 0)
        {
            Debug.Log("My hand is " + numberCard1 + typeOfCard1 + ", " + numberCard2 + typeOfCard2
        + ", " + numberCard3 + typeOfCard3 + ", " + numberCard4 + typeOfCard4 + " You Win!");
            isPlaying = false;
        }
        //Checks for win condition 2 3 4
        else if (string.Compare(typeOfCard2, typeOfCard3) == 0 && string.Compare(typeOfCard3, typeOfCard4) == 0)
        {
            Debug.Log("My hand is " + numberCard1 + typeOfCard1 + ", " + numberCard2 + typeOfCard2
        + ", " + numberCard3 + typeOfCard3 + ", " + numberCard4 + typeOfCard4 + " You Win!");
            isPlaying = false;
        }
        //Checks for win condition 1 2 4
        else if (string.Compare(typeOfCard1, typeOfCard2) == 0 && string.Compare(typeOfCard2, typeOfCard4) == 0)
        {
            Debug.Log("My hand is " + numberCard1 + typeOfCard1 + ", " + numberCard2 + typeOfCard2
        + ", " + numberCard3 + typeOfCard3 + ", " + numberCard4 + typeOfCard4 + " You Win!");
            isPlaying = false;
        }
        //Checks for win condition 1 3 4
        else if (string.Compare(typeOfCard1, typeOfCard3) == 0 && string.Compare(typeOfCard3, typeOfCard4) == 0)
        {
            Debug.Log("My hand is " + numberCard1 + typeOfCard1 + ", " + numberCard2 + typeOfCard2
        + ", " + numberCard3 + typeOfCard3 + ", " + numberCard4 + typeOfCard4 + " You Win!");
            isPlaying = false;
        }
        else
        {
            Debug.Log("My hand is " + numberCard1 + typeOfCard1 + ", " + numberCard2 + typeOfCard2
            + ", " + numberCard3 + typeOfCard3 + ", " + numberCard4 + typeOfCard4 + " This is not a winning hand");
            Debug.Log("Drawing new cards");
        }
    }
}
