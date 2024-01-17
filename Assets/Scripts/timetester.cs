using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class timetester : MonoBehaviour
{
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (Input.GetKeyDown("space"))
        {
            print(t);
        }
    }
}
