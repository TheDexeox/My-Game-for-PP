using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public string Level2;
    public RectTransform WinPanel;
    // Start is called before the first frame update
    void Start()
    {
        WinPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            other.GetComponent<Player>().points += 1;
            Debug.Log("Winner!");
            WinPanel.gameObject.SetActive(true);

        }
    }
    public void LoadNewLevel()
        {
        SceneManager.LoadScene(Level2);
    }

}

