using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMainMenu : MonoBehaviour
{
    public Animator a_Animator;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        a_Animator = GetComponent<Animator>();
        a_Animator.SetBool("MenuSpin", false);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            a_Animator.SetBool("MenuSpin", true);
        }

        if (Menu.level == 0 && transform.position.x > 0)
        {
            transform.position += new Vector3(-0.2f, 0, 0);
        }
        if (Menu.level == 1 && transform.position.x > -14)
        {
            transform.position += new Vector3(-0.2f, 0, 0);
        }
        if (Menu.level == 2)
        {
            transform.position = new Vector3(14, -1.5f, 0);
        }
    }
}
