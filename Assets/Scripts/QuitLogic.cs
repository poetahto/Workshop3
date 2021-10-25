using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuitLogic : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Wants to quit");
    }
}
