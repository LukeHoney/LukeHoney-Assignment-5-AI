using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject[] spawnPoints; //Array of world postions for spawn point

    public GameObject Chicken1; //Refrence to Chicken 
    
    public int spawnNumberChicken; //refrence to random number generated for first chicken
    

    // Start is called before the first frame update
    void Start()
    {

        spawnPoints = GameObject.FindGameObjectsWithTag("Target"); // Finds all game objects with the tag 'spawn' to add to array

        spawnNumberChicken = UnityEngine.Random.Range(0, spawnPoints.Length); //Using a random number generator chooses an array number from list for first chicken
        
        Instantiate(Chicken1, spawnPoints[spawnNumberChicken].transform.position, Quaternion.identity); //moves chicken to location of randomly chosen array
        

    }
}
