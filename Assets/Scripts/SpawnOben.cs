using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOben : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Object, new Vector3(120.72f, 0.7f, 0), Quaternion.Euler(0f, 90f, 0f));
        Instantiate(Object, new Vector3(125.37f, 0.7f, 0), Quaternion.Euler(0f, 90f, 0f));
        Instantiate(Object, new Vector3(129.38f, 0.7f, 0), Quaternion.Euler(0f, 90f, 0f));

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        
    }
}
