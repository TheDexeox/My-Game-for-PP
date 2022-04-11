using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
public void CloseGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
