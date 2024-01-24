using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{

    public static bool nom5 = false, nom10 = false, nom20 = false, streakloss = false, levelEnd = false, levelStart = false;
    public int  multiplier = 1, multiplierlol = 0, newHighscore = 0;
    public float score = 0;

    public TextMeshProUGUI scoreText, multiplierText, levelComplete, scoreEnd, newHighscoretext;

    public AudioSource fail;
    // Start is called before the first frame update
    void Start()
    { 
        nom5 = false;
        nom10 = false;
        nom20 = false;
        streakloss = false;
        levelEnd = false;
        newHighscore = 0;
        score = 0;
        multiplier = 1;
        multiplierlol = 0;
        scoreText.text = "0";
        multiplierText.text = "x1";
    }

    // Update is called once per frame
    void Update()
    {
        if (multiplierlol > 9 && multiplier < 8)
        {
            multiplierlol = 0;
            multiplier = (multiplier * 2);
            multiplierText.text = "x" + multiplier.ToString();
        }

        if (streakloss == true)
        {
            if(multiplier >1)
            {
                fail.Play();
            }
            streakloss = false;
            multiplierlol = 0;
            multiplier = 1;
            multiplierText.text = "x" + multiplier.ToString();
        }

        if (nom5 == true)
        {
            nom5 = false;
            score = score + (5 * multiplier);
            scoreText.text = score.ToString();
            multiplierlol++; 
        }
        else if (nom10 == true)
        {
            nom10 = false;
            score = score + (10 * multiplier);
            scoreText.text = score.ToString();
            multiplierlol++;
        }
        else if (nom20 == true)
        {
            nom20 = false;
            score = score + (20 * multiplier);
            scoreText.text = score.ToString();
            multiplierlol++;
        }

        if(levelEnd == true)
        {
            scoreEnd.text = "Score: " + score.ToString();
            if (score > Menu.highscoreTutorial && Menu.level == 1)
            {
                newHighscore = 1;
                Menu.highscoreTutorial = score;
            }
            else if (score > Menu.highscorePortOrmos && Menu.level == 2)
            {
                newHighscore = 1;
                Menu.highscorePortOrmos = score;
            }

            if (levelComplete.fontSize < 40)
            {
                levelComplete.fontSize += 1;
                scoreEnd.fontSize += 1;
            }

            if (newHighscore == 1)
            {
                if (newHighscoretext.fontSize < 25)
                {
                    newHighscoretext.fontSize += 0.25f;
                }
                if (newHighscoretext.fontSize >= 25)
                {
                    newHighscore = 2;
                }
            }
            else if (newHighscore == 2)
            {
                if (newHighscoretext.fontSize > 15)
                {
                    newHighscoretext.fontSize -= 0.25f;
                }
                if (newHighscoretext.fontSize <= 15)
                {
                    newHighscore = 1;
                }
            }
        }
        
    }
}
