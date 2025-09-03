using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Security.Cryptography;
using System.Collections.Generic;
 using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class RecationTime : MonoBehaviour
{
   
    // Alle letters
    List<char> letters = new List<char>(); //Hier zitten alle letters van A tot Z in.

    //  Level
    int currentLevel = 1; //welk level je nu speelt.

    //  Letters die je moet typen
    string targetWord = ""; //et woord dat je moet typen.
    int currentIndex = 0; //welke letter van het woord je nu moet typen

    //  Timer
    public float timePerLevel = 8f;
    float timer;

    // UI
    public TextMeshProUGUI letterText; //: laat zien welk woord je moet typen en welke letter je nu moet typen (die wordt geel).
    public TextMeshProUGUI timerText; //: laat zien hoeveel seconden je nog hebt.
    public TextMeshProUGUI levelText; //aat zien in welk level je zi

    private void Start()
    {
        // Zet alle letters in de lijst
        for (char c = 'A'; c <= 'Z'; c++)//loopt van A tot Z.
        {
            letters.Add(c); // stopt elke letter in de lijst.
        }

        StartLevel(1);//begint het eerste level van het spel.
    }

    void StartLevel(int level)//start een nieuw level.
    {
        currentLevel = level;//slaat het level op.
        timer = timePerLevel;//zet de tijd terug.
        targetWord = "";//leeg woord, wordt nog gemaakt.
        currentIndex = 0;//begint bij de eerste letter.

        // Bepaal aantal letters per level
        int letterCount = 0;
        if (level == 1) letterCount = 4;
        else if (level == 2) letterCount = 6;
        else if (level == 3) letterCount = 10;

        // Maak random woord
        for (int i = 0; i < letterCount; i++)
        {
            int index = Random.Range(0, letters.Count); //kiest een willekeurige letter.
            targetWord += letters[index]; //voegt die letter toe aan het woord.
        }

      UpdateUI();//Laat het woord, de timer en het level zien op het scherm.
    }

    private void Update() //De timer gaat naar beneden. > game over /// Checkt het spel of je de juiste letter hebt getypt.//Ja? dan ga je naar de volgende level
    {
        // Timer aftellen
        timer -= Time.deltaTime;//telt de tijd af.
        timerText.text = "Tijd: " + Mathf.Ceil(timer); //toont de lopende tijd op het scherm.

        if (timer <= 0f)
        {
            GameOver();
        }

        // Toets checken
        if (Input.anyKeyDown)
        {
            string keyPressed = Input.inputString.ToUpper(); // TopUpper =Zet de toets om naar hoofdletters

            if (keyPressed == targetWord[currentIndex].ToString())//Checkt of het overeenkomt met de huidige letter in het woord.
            {
                currentIndex++; // currentIndex++ = ga naar de volgende letter

                if (currentIndex >= targetWord.Length)
                {
                    //  alle letters goed → volgende level
                    StartLevel(currentLevel + 1);
                }
                else
                {
                   UpdateUI();
                }
            }
            else
            {
               // GameOver();
            }
        }
    }
    void UpdateUI() 
    {//ChatGPT gebruik gemaakt
        // Highlight de huidige letter
        string show = "";
        for (int i = 0; i < targetWord.Length; i++)
        {
            if (i == currentIndex)
                show += "<color=yellow>" + targetWord[i] + "</color> "; 
            else
                show += targetWord[i] + " ";
        }

        letterText.text = "Typ: " + show;
        levelText.text = "Level: " + currentLevel;
    }

    void GameOver()
    {//Print “Game Over” in de console.

        //Start het spel opnieuw bij level 1.
         Debug.Log("Game Over! Terug naar level 1.");
        StartLevel(1);
    }


}


