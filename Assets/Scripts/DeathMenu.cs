using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject deathMenuUI;
    public int score;

    public void DMenu()
    {
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        deathMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    } 

        public void LoadMenu() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        AudioManager.instance.StopPlaying("GameMusic");
        //FindObjectOfType<AudioManager> ().StopPlaying ("GameMusic");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
