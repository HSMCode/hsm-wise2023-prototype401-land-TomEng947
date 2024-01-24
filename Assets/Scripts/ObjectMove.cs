using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
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

        if (transform.position.x < -4 && transform.position.x >= -6 && MoleControl.oben == 1)
        {
            hit.Play();
            transform.position += new Vector3(-10f, 0, 0);
            Score.nom10 = true;
        }
        else if (transform.position.x < -6 && transform.position.x >= -8 && MoleControl.oben == 1)
        {
            hit.Play();
            transform.position += new Vector3(-10f, 0, 0);
            Score.nom5 = true;
        }
        else if (transform.position.x < -11 && transform.position.x >= -13)
        {
            Score.streakloss = true;
            Destroy(gameObject);
        }
        

        if (transform.position.x < -22) 
        {
            Destroy(gameObject);
        }
    }

    
}
