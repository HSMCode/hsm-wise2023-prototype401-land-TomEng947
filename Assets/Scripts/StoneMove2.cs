using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMove2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.2f, 0, 0);

        if (transform.position.x < -4 && transform.position.x >= -7 && MoleControl.oben == 2)
        {
            Score.streakloss = true;
        }

        if (transform.position.x < -22) 
        {
            Destroy(gameObject);
        }
    }

    
}
