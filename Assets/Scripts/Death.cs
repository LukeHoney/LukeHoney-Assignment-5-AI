using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class Death : MonoBehaviour
{
    public InMemoryVariableStorage yarnInMemoryStorage;

    [YarnCommand("Health")]
    public void DeathSelector()
    {
        float Health;
        yarnInMemoryStorage.TryGetValue("$Health", out Health);

        if (Health < 1)
        {
            LoadDeath();
          
        }

    }
    public void LoadDeath()
    {
        SceneManager.LoadScene("Death");
        
    }
}
