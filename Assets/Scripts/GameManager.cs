using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public static int highScore;
    public int coins = 0;

    public Text scoreDisplay;
    public Text highScoreDisplay;
    public Text coinsDisplay;

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    private void Awake()
    {
        instance = this;

        if(PlayerPrefs.HasKey("HighScore"))
        {
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreDisplay.text = "HIGHSCORE: " + highScore;
        }

        if(PlayerPrefs.HasKey("Coins"))
        {
        coins = PlayerPrefs.GetInt("Coins");
        }
    }

    public void Update()
    {
        if (score == 200 && GlobalAchievements.ach05Code != 05)
            {
                GlobalAchievements.ach05Count += 1;
            }

        if (score == 300 && GlobalAchievements.ach06Code != 06)
            {
                GlobalAchievements.ach06Count += 1;
            }
        
        if (score == 500 && GlobalAchievements.ach07Code != 07)
            {
                GlobalAchievements.ach07Count += 1;
            }
    }

    public void EndGame ()
    {
        if (gameHasEnded == false) // first time game has ended is false so this is going to be true
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            LoadMenu();
        }
    }
    
    void LoadMenu ()
    {
        FindObjectOfType<DeathMenu>().DMenu();
    }

    public void AddScore()
    {
        score++;
        coins++;

        UpdateCoins();
        UpdateHighScore();

        scoreDisplay.text = "SCORE: " + score;
    }

        public void AddScore5()
    {
        score+=5;
        coins+=5;

        UpdateCoins();
        UpdateHighScore();

        scoreDisplay.text = "SCORE: " + score;
    }

    public void UpdateHighScore()
    {
        if(score > highScore)
        {
            highScore = score;

            highScoreDisplay.text = "HIGHSCORE: " + highScore;

            PlayerPrefs.SetInt("HighScore", highScore);
        }        
    }

    public void ClearHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");

        highScore = 0;
        highScoreDisplay.text = "HIGHSCORE: " + highScore;
    }

    public void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        coinsDisplay.text = "COINS: " + coins;
    }
}