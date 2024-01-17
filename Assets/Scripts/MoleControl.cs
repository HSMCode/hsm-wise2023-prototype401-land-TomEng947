using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoleControl : MonoBehaviour
{
    public float jump, t, intheAir;
    public int jumpForce, oben;
    //public bool oben;
    private Rigidbody rb;
    private CapsuleCollider collider;
    private MoleControl MoleControlScript;

    public AudioSource hit;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 120;
        MoleControlScript = GameObject.Find("Mole").GetComponent<MoleControl>();
        jump = 0;
        t = 0;
        jumpForce = 13;
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<CapsuleCollider>();
        oben = 1;
        intheAir = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        


        if (Input.GetKeyDown("space") && oben == 1)
        {
            jump = 0;
            oben = 2; 
        }
        else if (Input.GetKeyDown("space") && oben == 2)
        {
            jump = 0;
            oben = 1;
        }


        if (oben == 2 && transform.position.y > -2.8)
        {
            rb.useGravity = false;
            transform.position += new Vector3(0, -0.825f, 0);
        }

        if (Input.GetKey("space") && oben == 2)
        {
            jump += Time.deltaTime;
        }

        if (oben == 1 && transform.position.y < 0.1)
        {
            rb.useGravity = true;
            transform.position += new Vector3(0, 0.825f, 0);
        }

        if (Input.GetKeyUp("space") && jump >= 1.5f && oben == 2)
        {
            oben = 3;
            jump = 0;
            collider.enabled = false;
            rb.useGravity = true;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (oben == 3)
        {
            intheAir += Time.deltaTime;
            if (intheAir > 2)
            { 
                collider.enabled = true;
                oben = 1;
                intheAir = 0;
            }
        }
    }

    
}
