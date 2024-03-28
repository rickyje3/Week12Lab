using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Task2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] nameList = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Isaac", "Julia", "Kevin", "Linda", "Michael", "Nancy", "Olivia", "Patrick", "Quinn", "Rachel", "Sarah", "Tom" };

        // Create a HashSet to store unique names
        HashSet<string> uniqueNames = new HashSet<string>();

        // String array to store random names
        string[] randomNames = new string[15];

        // Random object for generating random numbers
        Random random = new Random();

        // Populate randomNames array with 15 random names from nameList
        for (int i = 0; i < 15; i++)
        {
            int randomIndex = random.Next(0, nameList.Length);
            randomNames[i] = nameList[randomIndex];
        }

        // Output created name array
        string createdNamesString = "Created the name array: " + string.Join(", ", randomNames);
        Debug.Log(createdNamesString);

        // Check for duplicates using HashSet
        HashSet<string> duplicateNames = new HashSet<string>();
        foreach (string name in randomNames)
        {
            if (!uniqueNames.Add(name))
            {
                duplicateNames.Add(name);
            }
        }

        // Output if array has duplicate names
        if (duplicateNames.Count > 0)
        {
            string duplicateNamesString = "The array has duplicate names: " + string.Join(", ", duplicateNames);
            Debug.Log(duplicateNamesString);
        }

    }
}
