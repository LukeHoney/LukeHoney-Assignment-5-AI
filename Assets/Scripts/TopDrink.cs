using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class TopDrink : MonoBehaviour
{
    //Script that changes to end screen depending on players choices

    public InMemoryVariableStorage yarnInMemoryStorage;

    [YarnCommand("DrinkSelector")]
    public void DrinkSelector()
    {
        string drink;
        yarnInMemoryStorage.TryGetValue("$drink", out drink);

        if (drink == "TopDrink")
        {
            LoadTopDrink();
        }

        if (drink == "Coke")
        {
            LoadCokeDrink();
        }

        if (drink == "Water")
        {
            LoadWaterDrink();
        }

    }
    public void LoadTopDrink()
    {
        SceneManager.LoadScene("TopDrink");
     
    }
    public void LoadCokeDrink()
    {
        SceneManager.LoadScene("Coke");

    }
    public void LoadWaterDrink()
    {
        SceneManager.LoadScene("Water");

    }
}
