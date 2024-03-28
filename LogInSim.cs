using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogInSim : MonoBehaviour
{
    public List<string> firstNames = new List<string>()
    {
        "Kobe",
        "Michael",
        "LeBron",
        "Stephen",
        "Kareem",
        "Thabo",
        "Boban",
        "Jason",
        "Derrick",
        "Kyrie",
        "Cole",
        "Markelle",
        "Kevin",
        "Luka",
        "Trae",
        "Ben",
        "Paul",
        "Muggsy",
        "Karl",
        "Andrew",
        "Anthony",
        "Jordan",
        "Nickeil",
        "Shai",
        "Jayson",
        "Jaylen"
    };

    public List<string> lastNames = new List<string>()
    {
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
        "G",
        "H",
        "I",
        "J",
        "K",
        "L",
        "M",
        "N",
        "O",
        "P",
        "Q",
        "R",
        "S",
        "T",
        "U",
        "V",
        "W",
        "X",
        "Y",
        "Z"
    };

    Queue<string> activePlayers = new Queue<string>();
    public bool enteringQueue;
    int nameRnd;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        int nameRnd = Random.Range(0, 25);
        enteringQueue = true;
        while (enteringQueue == true)
        {
            yield return new WaitForSeconds(3f);
            NameRandomizer();
        }
    }

    public void NameRandomizer()
    {
        string randomFirstName = firstNames[Random.Range(0, firstNames.Count)];
        string randomLastName = lastNames[Random.Range(0, lastNames.Count)];
        activePlayers.Enqueue(randomFirstName);
        activePlayers.Enqueue(randomLastName);
        Debug.Log(randomFirstName + randomLastName + " was added to the login queue");
        Debug.Log("Initial login queue created. There are 5 players in the queue:" + randomFirstName + randomLastName + randomFirstName + randomLastName + randomFirstName + randomLastName + randomFirstName + randomLastName + randomFirstName + randomLastName);
        Debug.Log(randomFirstName + randomLastName + " is now in the game");
        activePlayers.Dequeue();


    }

    public void PlayerLogIn(string randomFirstName, string randomLastName)
    {
        Debug.Log("Initial login queue created. There are 5 players in the queue:" + randomFirstName + randomLastName  +  randomFirstName + randomLastName + randomFirstName + randomLastName + randomFirstName + randomLastName + randomFirstName + randomLastName);
        Debug.Log(randomFirstName + randomLastName + " is now in the game");
        activePlayers.Dequeue();
    }

}
