using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerforWall : MonoBehaviour
{
    Vector3 down;
    bool open = false;

    // Start is called before the first frame update
    void Start()
    {
        down = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            transform.position = Vector3.Lerp(transform.position, down, 5f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            //docelowo -0.31 y na poczatku 1.3 
            //transform.position = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
            open = true;
        }
    }
}
