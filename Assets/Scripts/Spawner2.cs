using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner2 : MonoBehaviour
{
    public GameObject Object, Object2, Object3, stone, stone2;

    public float spawn, timer;
    public int count;
    public bool stonespawn = true;
    public RectTransform TutorialImage;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        spawn = 0;
        Score.levelStart = false;
        Score.levelEnd = false;
        stonespawn = true;
        TutorialImage.anchoredPosition = new Vector2(-395, -173);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //Hinderniss

        if (stonespawn == true)
        {
            if (count == 89 || count == 999)
            {
                stonespawn = false;
                Stone();
            }
            if ( count == 72 || count == 103 || count == 109)
            {
                stonespawn = false;
                Stone2();
            }
        }

        if (timer >= 0.375f)
        {
            timer = timer - 0.375f;
            if (count == 40 || count == 42 || count == 56 ||  count == 58 || count == 71 || count == 73 || count == 79 || count == 81 || count == 89 || count == 91 || count == 93 || count == 105 || count == 107)
            {
                Spawn();
                count++;
            }
            else if (count == 44 || count == 46 || count == 60 || count == 62 || count == 72 || count == 75 || count == 77 || count == 83 || count == 85 || count == 99 || count == 102 || count == 104 || count == 106 
                     || count == 110)
            {
                Spawn2();
                count++;
            }
            else if (count == 50 || count == 51 || count == 66 || count == 67)
            {
                Spawn3();
                count++;
            }
            else
            {
                count++;
            }
        } 

        // Hälfte
        else if (timer >= 0.1875f && timer <= 0.2075f)
        {
            if (count == 80 || count == 84 || count == 86 || count == 96)
            {
                Spawn();
                count++;
            }
            else if (count == 76 || count == 90 || count == 92 || count == 110)
            {
                Spawn2();
                count++;
            }
            else if (count == 999 || count == 999)
            {
                Spawn3();
                count++;
            }
        }

        // Viertel 1
        else if (timer >= 0.09375f && timer <= 0.10375f)
        {
            if (count == 95 || count == 109)
            {
                Spawn();
                count++;
            }
            else if (count == 100 || count == 999)
            {
                Spawn2();
                count++;
            }
            else if (count == 999)
            {
                Spawn3();
                count++;
            }
        }

        // Viertel 2
        else if (timer >= 0.28125f && timer <= 0.29125f)
        {
            if (count == 101 || count == 111)
            {
                Spawn();
                count++;
            }
            else if (count == 97 || count == 999)
            {
                Spawn2();
                count++;
            }
            else if (count == 999)
            {
                Spawn3();
                count++;
            }
        }

        // Drittel 1
        else if (timer >= 0.125f && timer <= 0.135f)
        {
            if (count == 999 || count == 999)
            {
                Spawn();
                count++;
            }
            else if (count == 999 || count == 999 )
            {
                Spawn2();
                count++;
            }
            else if (count == 999)
            {
                Spawn3();
                count++;
            }
        }

        // Drittel 2
        else if (timer >= 0.25f && timer <= 0.26f)
        {
            if (count == 990 || count == 990 )
            {
                Spawn();
                count++;
            }
            else if (count == 990 || count == 999)
            {
                Spawn2();
                count++;
            }
            else if (count == 990 || count == 999)
            {
                Spawn3();
                count++;
            }
        }

        if (count > 55)
        {
            Score.levelStart = true;
        }

        if (count > 145)
        {
            Score.levelEnd = true;
        }
        if (count > 148 && Input.GetKeyDown("space")) 
        {
            SceneManager.LoadScene("Menu");
        }

        if (TutorialImage.anchoredPosition.x > -1100 && count > 58)
        {
            TutorialImage.anchoredPosition += new Vector2(-10, 0);
        }
    }

    void Spawn()
    {
        Instantiate(Object, new Vector3(104f, 0.7f, 0), Quaternion.Euler(0f, -90f, 0f));
    }

    void Spawn2() 
    {
        Instantiate(Object2, new Vector3(104f, -3f, 0), Quaternion.Euler(0f, -90f, 0f));
    }

    void Spawn3()
    {
        Instantiate(Object3, new Vector3(104f, 5f, 0), Quaternion.Euler(0f, -90f, 0f));
    }
    void Stone()
    {
        Instantiate(stone, new Vector3(104f, 0.7f, 0), Quaternion.Euler(0f, 0f, 0f));
    }

    void Stone2()
    {
        Instantiate(stone2, new Vector3(104f, -3f, 0), Quaternion.Euler(0f, 0f, 0f));
    }
}
