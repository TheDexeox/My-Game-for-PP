using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Material Active;
    public Material NotActive;
    public Renderer Renderer;


    // Start is called before the first frame update
    void Start()
    {
        Renderer.material = NotActive;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            Renderer.material = Active;
            //Renderer.Material.CopyPropertiesFromMaterial(Active);
        }
    }
}
