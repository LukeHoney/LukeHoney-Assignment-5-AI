using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitGameScript : MonoBehaviour
{
   public void QuitGame() //Create a quit function
    {
        Application.Quit(); // Quiting Script
        Debug.Log("Quiting the Game"); //Shows quitting action in console
    }
}
