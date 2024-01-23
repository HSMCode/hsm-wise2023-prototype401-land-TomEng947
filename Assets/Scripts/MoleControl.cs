using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoleControl : MonoBehaviour
{
    public float jump, t, intheAir;
    public static int oben;
    private int jumpForce;
    //public bool oben;
    private Rigidbody rb;
    private CapsuleCollider collider;
    private MoleControl MoleControlScript;

    public AudioSource hit;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
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

        if (oben == 2)
        {
            jump += Time.deltaTime;
        }

        if (Input.GetKeyDown("space") && oben == 1)
        {
            jump = 0;
            oben = 2; 
        }

        else if (Input.GetKeyDown("space") && jump < 1 && oben == 2)
        {
            jump = 0;
            oben = 1;
        }
        else if (Input.GetKeyDown("space") && jump >= 1 && oben == 2)
        {
            oben = 4;
            jump = 0;
            collider.enabled = false;
            rb.useGravity = true;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (oben == 2 && transform.position.y > -2.8)
        {
            rb.useGravity = false;
            transform.position += new Vector3(0, -0.825f, 0);
        }

        if (oben == 1 && transform.position.y < 0.1)
        {
            rb.useGravity = true;
            transform.position += new Vector3(0, 0.825f, 0);
        }

        if (oben == 3 || oben == 4)
        {
            intheAir += Time.deltaTime;
            if (intheAir > 0.8)
            {   
                oben = 3; 
            }
            if (intheAir > 1.8)
            {
                oben = 4;
            }
            if (intheAir > 2.3)
            { 
                collider.enabled = true;
                oben = 1;
                intheAir = 0;
            }
        }
    }

   



}
