using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject Object, Object2, Object3;

    public float spawn, timer;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        spawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.63163f)
        {
            timer = timer - 0.63163f;
            if (count == 1 || count == 3 || count == 5 || count == 7 || count == 9 || count == 11 || count == 13 || count == 15 || count == 26 || count == 37 || count == 38 || count == 40 ||  count == 41 
                || count == 42 || count == 46 || count == 51 || count == 52 || count == 56 || count == 58 || count == 60 || count == 62 || count == 64 || count == 68 || count == 70 || count == 81 || 
                count == 85 || count == 86 || count == 89 || count == 91 || count == 93 || count == 96 || count == 98 || count == 108 || count == 113 || count == 116 || count == 120 || count == 121 
                || count == 126 || count == 128 || count == 130 || count == 131 || count == 132 || count == 136 || count == 138 || count == 140 || count == 144 || count == 146 || count == 147 || count == 150 ||
                count == 154 || count == 155 || count == 165  || count == 169 || count == 171 || count == 180 || count == 185 || count == 187 || count == 189 || count == 195 || count == 206)
            {
                Spawn();
                count++;
            }
            else if (count == 2 || count == 4 || count == 6 || count == 10 || count == 12 || count == 14 || count == 16 || count == 18 || count == 25 || count == 27 || count == 29  || count == 43 
                     || count == 45 || count == 47 || count == 50 || count == 59 || count == 67 || count == 69 || count == 71 || count == 72 || count == 73 || count == 92 || count == 97 || count == 99  ||
                     count == 100 || count == 111 || count == 112 || count == 118 || count == 123 || count == 129 || count == 135 || count == 137 || count == 142 || count == 145 || count == 151 || count == 153
                     || count == 159 || count == 170 || count == 172 || count == 176 || count == 181 || count == 192 || count == 198 || count == 202 || count == 210)
            {
                Spawn2();
                count++;
            }
            else if (count == 21 || count == 31 || count == 75 || count == 77 ||  count == 105 || count == 212 || count == 214)
            {
                Spawn3();
                count++;
            }
            else
            {
                count++;
            }

            //Hinderniss
            if(count == 999 || count == 999)
            {

            }
        } 

        // Hälfte
        else if (timer >= 0.315815f && timer <= 0.355815f)
        {
            if (count == 8 || count == 44 || count == 61 || count == 87 || count == 117 || count == 119 || count == 122 || count == 141 || count == 152 || count == 157 || count == 161 || count == 167
                || count == 174 || count == 182 || count == 191 || count == 197 || count == 204)
            {
                Spawn();
                count++;
            }
            else if (count == 17 || count == 28 || count == 39 || count == 57 || count == 59 || count == 63 || count == 83 || count == 90 || count == 110 || count == 127 || count == 137 || count == 143
                     || count == 178 || count == 194 || count == 200 || count == 208)
            {
                Spawn2();
                count++;
            }
            else if (count == 22 || count == 76 || count == 213 || count == 215)
            {
                Spawn3();
                count++;
            }
        }

        // Viertel 1
        else if (timer >= 0.15790f && timer <= 0.18790f)
        {
            if (count == 109 || count == 136 || count == 177 || count == 193 || count == 199 || count == 203)
            {
                Spawn();
                count++;
            }
            else if (count == 82 || count == 139 || count == 156 || count == 160 || count == 166 || count == 173 || count == 190 || count == 196 || count == 207)
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
        else if (timer >= 0.47372f && timer <= 0.50372f)
        {
            if (count == 138 || count == 158 || count == 175 || count == 179 || count == 201)
            {
                Spawn();
                count++;
            }
            else if (count == 84 || count == 111 || count == 162 || count == 168 || count == 184 || count == 186 || count == 188 || count == 205 || count == 209)
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
        else if (timer >= 0.21054f && timer <= 0.24074f)
        {
            if (count == 48 || count == 55 || count == 124)
            {
                Spawn();
                count++;
            }
            else if (count == 53 || count == 87 || count == 94 || count == 101 || count == 114 || count == 148 )
            {
                Spawn2();
                count++;
            }
            else if (count == 32 )
            {
                Spawn3();
                count++;
            }
        }

        // Drittel 2
        else if (timer >= 0.42108f && timer <= 0.46128f)
        {
            if (count == 49 || count == 56 )
            {
                Spawn();
                count++;
            }
            else if (count == 54 || count == 88 || count == 95 || count == 102 || count == 115 || count == 125 || count == 149)
            {
                Spawn2();
                count++;
            }
            else if (count == 33 || count == 104)
            {
                Spawn3();
                count++;
            }
        }

        if (count > 235)
        {
            Score.levelEnd = true;
        }
        if (count > 240 && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void Spawn()
    {
        Instantiate(Object, new Vector3(107f, 0.7f, 0), Quaternion.Euler(0f, -90f, 0f));
    }

    void Spawn2()
    {
        Instantiate(Object2, new Vector3(107f, -3f, 0), Quaternion.Euler(0f, -90f, 0f));
    }

    void Spawn3()
    {
        Instantiate(Object3, new Vector3(107f, 5f, 0), Quaternion.Euler(0f, -90f, 0f));
    }
}
