using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndCollision : MonoBehaviour
{

    public AudioSource hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hit")
        {
            hit.Play();
            Debug.Log("Hi");
        }
    }
}
