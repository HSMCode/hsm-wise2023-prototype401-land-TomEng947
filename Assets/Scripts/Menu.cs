using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public static float highscoreTutorial, highscorePortOrmos;
    public static int level;
    public int start;
    public bool click;
    public TextMeshProUGUI hsTutorial, hsPortOrmos;
    public RectTransform PortOrmosImage, PortOrmosText, PortOrmosHighscoreText, PortOrmosHighscore;
    public RectTransform StartImage, StartText; 
    public RectTransform TutorialImage, TutorialText, TutorialHighscoreText, TutorialHighscore;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        level = 0;
        start = 0;
        click = false;

        StartImage.anchoredPosition = new Vector2(5, 30);
        StartText.anchoredPosition = new Vector2(0, 44);
        TutorialImage.anchoredPosition = new Vector2(700, 30);
        TutorialText.anchoredPosition = new Vector2(618, -188);
        TutorialHighscoreText.anchoredPosition = new Vector2(624, -231);
        TutorialHighscore.anchoredPosition = new Vector2(664, -258);
        PortOrmosImage.anchoredPosition = new Vector2(-700, 30);
        PortOrmosText.anchoredPosition = new Vector2(-782, -178);
        PortOrmosHighscoreText.anchoredPosition = new Vector2(-776, -221);
        PortOrmosHighscore.anchoredPosition = new Vector2(-736, -248);

        hsTutorial.text = highscoreTutorial.ToString();
        hsPortOrmos.text = highscorePortOrmos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        hsTutorial.text = highscoreTutorial.ToString();
        hsPortOrmos.text = highscorePortOrmos.ToString();
        if (Input.GetKeyUp("space") && click == true && start < 60)
        {
            if(level >= 2)
            {
                level = 0;
                click = false;
            }
            else
            {
                level++;
                click = false;
            }
        }
        if (start >= 60)
        {
            if (level == 1)
            {
                SceneManager.LoadScene("CheckerDance");
            }
            else if (level == 2)
            {
                SceneManager.LoadScene("PortOrmos");
            }
        }
        if (Input.GetKeyUp("space"))
            {
            start = 0;
            }

        if (Input.GetKey("space"))
        {
            start++;
        }

        if (level == 0)
        {
            if (StartImage.anchoredPosition.x > 5)
            {
                PortOrmosImage.anchoredPosition += new Vector2(-10, 0);
                PortOrmosText.anchoredPosition += new Vector2(-10, 0);
                PortOrmosHighscoreText.anchoredPosition += new Vector2(-10, 0);
                PortOrmosHighscore.anchoredPosition += new Vector2(-10, 0);
                StartImage.anchoredPosition += new Vector2(-10, 0);
                StartText.anchoredPosition += new Vector2(-10, 0);
                TutorialImage.anchoredPosition = new Vector2(700, 30);
                TutorialText.anchoredPosition = new Vector2(618, -188);
                TutorialHighscoreText.anchoredPosition = new Vector2(624, -231);
                TutorialHighscore.anchoredPosition = new Vector2(664, -258);
            }
            else if(StartImage.anchoredPosition.x <= 5) 
            {
                click = true;
            }
        }
        else if (level == 1)
        {
            if (TutorialImage.anchoredPosition.x > 5)
            {
                PortOrmosImage.anchoredPosition = new Vector2(700, 30);
                PortOrmosText.anchoredPosition = new Vector2(618, -178);
                PortOrmosHighscoreText.anchoredPosition = new Vector2(624, -221);
                PortOrmosHighscore.anchoredPosition = new Vector2(664, -248);
                StartImage.anchoredPosition += new Vector2(-10, 0);
                StartText.anchoredPosition += new Vector2(-10, 0);
                TutorialImage.anchoredPosition += new Vector2(-10, 0);
                TutorialText.anchoredPosition += new Vector2(-10, 0);
                TutorialHighscoreText.anchoredPosition += new Vector2(-10, 0);
                TutorialHighscore.anchoredPosition += new Vector2(-10, 0);
            }
            else if (TutorialImage.anchoredPosition.x <= 5)
            {
                click = true;
            }
        }
        else if (level == 2)
        {
            if (PortOrmosImage.anchoredPosition.x > 5)
            {
                PortOrmosImage.anchoredPosition += new Vector2(-10, 0);
                PortOrmosText.anchoredPosition += new Vector2(-10, 0);
                PortOrmosHighscoreText.anchoredPosition += new Vector2(-10, 0);
                PortOrmosHighscore.anchoredPosition += new Vector2(-10, 0);
                StartImage.anchoredPosition = new Vector2(700, 30);
                StartText.anchoredPosition = new Vector2(700, 44);
                TutorialImage.anchoredPosition += new Vector2(-10, 0);
                TutorialText.anchoredPosition += new Vector2(-10, 0);
                TutorialHighscoreText.anchoredPosition += new Vector2(-10, 0);
                TutorialHighscore.anchoredPosition += new Vector2(-10, 0);
            }
            else if (PortOrmosImage.anchoredPosition.x <= 5)
            {
                click = true;
            }
        }
    }
}
