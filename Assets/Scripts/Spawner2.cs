using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner2 : MonoBehaviour
{
    public GameObject Object, Object2, Object3, stone, stone2;

    public float spawn, timer;
    public int count;
    public bool stonespawn = true;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        spawn = 0;
        Score.levelStart = false;
        Score.levelEnd = false;
        stonespawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //Hinderniss

        if (stonespawn == true)
        {
            if (count == 88 || count == 113)
            {
                stonespawn = false;
                Stone();
            }
            if ( count == 71 || count == 201)
            {
                stonespawn = false;
                Stone2();
            }
        }

        if (timer >= 0.375f)
        {
            timer = timer - 0.375f;
            if (count == 39 || count == 41 || count == 55 ||  count == 57)
            {
                Spawn();
                count++;
            }
            else if (count == 43 || count == 45 || count == 59 || count == 61)
            {
                Spawn2();
                count++;
            }
            else if (count == 49 || count == 50 || count == 65 || count == 66)
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
        else if (timer >= 0.1875f && timer <= 0.1975f)
        {
            if (count == 119 || count == 122 || count == 141 )
            {
                Spawn();
                count++;
            }
            else if (count == 199 || count == 99 || count == 99 || count == 99 )
            {
                Spawn2();
                count++;
            }
            else if (count == 99 || count == 99 || count == 213 || count == 215)
            {
                Spawn3();
                count++;
            }
        }

        // Viertel 1
        else if (timer >= 0.09375f && timer <= 0.10375f)
        {
            if (count == 109 || count == 136 || count == 177 || count == 193 || count == 199 || count == 203)
            {
                Spawn();
                count++;
            }
            else if (count == 99 || count == 139 || count == 156 || count == 160 || count == 166 || count == 173 || count == 190 || count == 196 || count == 207)
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
            if (count == 138 || count == 158 || count == 175 || count == 179 || count == 201)
            {
                Spawn();
                count++;
            }
            else if (count == 99 || count == 111 || count == 162 || count == 168 || count == 184 || count == 186 || count == 188 || count == 205 || count == 209)
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
            if (count == 99 || count == 99 || count == 99)
            {
                Spawn();
                count++;
            }
            else if (count == 99 || count == 99 || count == 99 || count == 99 || count == 99 || count == 99)
            {
                Spawn2();
                count++;
            }
            else if (count == 99)
            {
                Spawn3();
                count++;
            }
        }

        // Drittel 2
        else if (timer >= 0.25f && timer <= 0.26f)
        {
            if (count == 99 || count == 99 )
            {
                Spawn();
                count++;
            }
            else if (count == 99 || count == 99 || count == 99 || count == 99 || count == 99 || count == 99 || count == 99)
            {
                Spawn2();
                count++;
            }
            else if (count == 99 || count == 99)
            {
                Spawn3();
                count++;
            }
        }

        if (count > 1)
        {
            Score.levelStart = true;
        }

        if (count > 130)
        {
            Score.levelEnd = true;
        }
        if (count > 133 && Input.GetKeyDown("space")) 
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void Spawn()
    {
        Instantiate(Object, new Vector3(104.6f, 0.7f, 0), Quaternion.Euler(0f, -90f, 0f));
    }

    void Spawn2() 
    {
        Instantiate(Object2, new Vector3(104.6f, -3f, 0), Quaternion.Euler(0f, -90f, 0f));
    }

    void Spawn3()
    {
        Instantiate(Object3, new Vector3(104.6f, 5f, 0), Quaternion.Euler(0f, -90f, 0f));
    }
    void Stone()
    {
        Instantiate(stone, new Vector3(104.6f, 0.7f, 0), Quaternion.Euler(0f, 0f, 0f));
    }

    void Stone2()
    {
        Instantiate(stone2, new Vector3(104.6f, -3f, 0), Quaternion.Euler(0f, 0f, 0f));
    }
}
