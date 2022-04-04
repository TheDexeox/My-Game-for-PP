using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Coins : MonoBehaviour
{
    public int prize = 1;
    public Renderer renderer;

    private bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        collected = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1.5f, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true && collected == false)
        {

            collected = true;
            transform.DOMoveY(transform.position.y + 2.0f, 1.0f);
            renderer.material.DOFade(0, 1.0f)
            .OnComplete(() => { Destroy(gameObject); });
            other.GetComponent<Player>().points += prize;
        }
        
    }
}
