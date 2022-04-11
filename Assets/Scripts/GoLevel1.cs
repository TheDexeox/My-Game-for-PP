using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel1 : MonoBehaviour
{
    public string Level1;
    public void LoadNewLevel()
    {
        SceneManager.LoadScene(Level1);
    }
}
