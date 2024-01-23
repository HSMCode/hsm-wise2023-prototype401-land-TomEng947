using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove2: MonoBehaviour
{
    public AudioSource hit;
    public static bool combo;
    // Start is called before the first frame update
    void Start()
    {
        combo = true; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.2f, 0, 0);

        if (transform.position.x < -4 && transform.position.x > -8 && MoleControl.oben == 2)
        {
            hit.Play();
            transform.position += new Vector3(-10f, 0, 0);
            
        }

        if (transform.position.x < -22) 
        {
            Destroy(gameObject);
        }
    }

    
}
