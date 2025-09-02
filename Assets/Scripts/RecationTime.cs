using UnityEngine;
using TMPro;
using NUnit.Framework;
using System.Security.Cryptography;
using System.Collections.Generic;

public class RecationTime : MonoBehaviour
{
    public TextMeshProUGUI letterText;   // Dit is de tekst op het scherm waar de letter komt
    public TextMeshProUGUI timerText;    // Dit is de tekst op het scherm waar de klok komt
    public float timeLimit = 3f;         // Dit is hoeveel seconden je krijgt 

    private float timer;                 // Dit is de klok die aftelt
    private char currentLetter;          // Dit is de letter die je moet drukken
    private bool gameActive;             // Dit zegt of het spel bezig is (true) of niet (false)

    List<char> letters = new List<char>();  // lijst van letters
   

    private void Start()
    {
        // lijst vullen met letters// 
      for (char c ='A'; c <= 'Z'; c++) 
        { 
        letters.Add(c);
        }

        ShowRandomLetter();
        
        
        //StartNewRound();
    }

    private void ShowRandomLetter()
    {
        // Kies een random index uit de lijst
        int index = Random.Range(0, letters.Count);
        currentLetter = letters[index];

        // Toon de letter in de Console
        Debug.Log("Random letter: " + currentLetter);
    }



    /*  private void Update()
      {

          if (Input.anyKeyDown)            // Als je een toets indrukt…
          {
              // de random letter die laat zien is de huidige letter / die toets is de juiste letter
              {
                  Succes();               // …dan heb je gewonnen
              }
              else                         // Maar als het de verkeerde toets is
              {
                  Fail();                  // …dan heb je verloren
              }
          }
      }

      void StartNewRound()                 // Dit begint een nieuwe ronde
      {
          timer = timeLimit;               // Zet de klok weer op de begintijd
          gameActive = true;               // Zet het spel aan (je bent bezig
      }
      void Fail()
      {

      }

      void Succes()
      {

      }*/

    private void Update()
    {
        // Druk op spatie voor een nieuwe random letter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowRandomLetter();
        }
    }
}


