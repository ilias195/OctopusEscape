using UnityEngine;
using TMPro;

public class RecationTime : MonoBehaviour
{
    public TextMeshProUGUI letterText;   // Dit is de tekst op het scherm waar de letter komt
    public TextMeshProUGUI timerText;    // Dit is de tekst op het scherm waar de klok komt
    public float timeLimit = 3f;         // Dit is hoeveel seconden je krijgt (3 = drie seconden)

    private float timer;                 // Dit is de klok die aftelt
    private char currentLetter;          // Dit is de letter die je moet drukken
    private bool gameActive;             // Dit zegt of het spel bezig is (true) of niet (false)

    private void Start()
    {
        StartNewRound();
    }

    private void Update()
    {
        if (Input.anyKeyDown)            // Als je een toets indrukt…
        {
            if (Input.inputString.ToUpper() == currentLetter.ToString()) // …en die toets is de juiste letter
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

    }


}


