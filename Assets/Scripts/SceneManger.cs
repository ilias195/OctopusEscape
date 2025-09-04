using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{

    // Functie voor de Start-knop
    public void StartGame()
    {
        Debug.Log("Game start!");
        // Zorg dat je jouw spel-scene toevoegt bij File > Build Settings > Scenes In Build
        SceneManager.LoadScene(1);
    }

    // Functie voor de Info-knop
    public void ShowInfo()
    {
        Debug.Log("Info scherm openen...");
        // Hier kun je een apart paneel activeren of een popup laten zien
    }

    // (Optioneel) functie voor een Quit-knop
    public void QuitGame()
    {
        Debug.Log("Quit game");
        Application.Quit(); // Werkt alleen in de build, niet in de editor
    }
}
