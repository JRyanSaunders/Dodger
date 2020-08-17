using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour 
{   
    public int coins;
    public int score;

    public Text coinsDisplay;

    public void Awake()
    {
        if(PlayerPrefs.HasKey("Coins")) {
        coins = PlayerPrefs.GetInt("Coins");
        }
    }

    public void Start(){
        //FindObjectOfType<AudioManager>().Play("MenuMusic");
        AudioManager.instance.Play("MenuMusic");
    }

    public void Update()
    {
        coinsDisplay.text = "COINS: " + coins;
    }

    public void PlayGame () 
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
        //FindObjectOfType<AudioManager> ().StopPlaying ("MenuMusic");
        //FindObjectOfType<AudioManager>().Play("GameMusic");
        AudioManager.instance.StopPlaying("MenuMusic");
        AudioManager.instance.Play("GameMusic");
        Shooting.ShootingIsActive = true;
    }
 
    public void QuitGame ()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
  
}