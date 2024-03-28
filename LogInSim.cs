using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogInSim : MonoBehaviour
{
    List<string> firstNames = new List<string>()
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

    List<string> lastNames = new List<string>()
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
            queuePrint();
        }
    }

    public void queuePrint()
    {
        activePlayers.Enqueue(firstNames[nameRnd]);
        Debug.Log("Initial login queue created. There are 5 players in the queue:" + activePlayers);
    }

}
