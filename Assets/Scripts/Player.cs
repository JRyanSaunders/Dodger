using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public int health = 10;
    public int stamina = 10;
    public static int score = 0;
    public int points = 0;
    //public int highScore;

    /*public Text highScoreDisplay;
    public Text healthDisplay;
    public Text scoreDisplay;*/
    
    public GameObject dashEffect;
    //public GameObject dashSound;

    private Rigidbody2D rb; 
    private Vector2 moveVelocity; 

    public Slider healthSlider;
    public Slider staminaSlider;

    private Coroutine regen; //stop regening if dash is used again

    public static int coins;
    int isSkin1Sold;
    int isSkin1Active;

    public Sprite skin0; // Drag your first sprite here

    private SpriteRenderer spriteRenderer;

    public void Awake(){
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        spriteRenderer.sprite = Shop.currentSkin;
    }


    void Start(){
        rb = GetComponent<Rigidbody2D>(); // Reference to rigid body in the start component

        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = skin0; // set the sprite to sprite1

        coins = PlayerPrefs.GetInt("Coins");
        isSkin1Sold = PlayerPrefs.GetInt ("IsSkin1Sold");

        /*if (isSkin1Sold == 1) // If the skin is sold == 1 then 
        {
            ChangeTheSprite (); // call method to change sprite
        }*/

    }

    void Update()
    {
        /*highScoreDisplay.text = "HIGHSCORE :" + highScore;
        healthDisplay.text = "HEALTH :" + health;
        scoreDisplay.text = "SCORE :" + score;*/

        if(health <= 0){
            FindObjectOfType<GameManager>().EndGame();  // strange line of code reloads current scene... lol
        }

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // Gets the player input from keys left key -1 right key +1, vice versa.
        moveVelocity = moveInput.normalized * speed; //adds a value to the input by multiplying it by speed, and then normalize fixes the double speed diagonally

        if (Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine ("DashMove");
        }
    }

    void FixedUpdate(){ // When moving objects with Rigidbody you usually write it in FixedUpdate
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime); // telling the programme to move the rigidbody
    } 
    // MovePosition is used to get an object from one place to the other, whereas moveVelcity is to control the force of an object

    public void SetMaxHealth(int health) 
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    public void SetMaxStamina(int stamina) 
    {
        staminaSlider.maxValue = stamina;
        staminaSlider.value = stamina;
    }

    public void SetStamina(int stamina)
    {
        staminaSlider.value = stamina;
    }

    IEnumerator DashMove()
    {
        if(staminaSlider.value >= 5){
        speed += 20;
        Instantiate(dashEffect, transform.position, Quaternion.identity);
        //FindObjectOfType<AudioManager>().Play("dash2");
        AudioManager.instance.Play("dash2");
        PlayerPrefs.SetInt("ach08Counter", GlobalAchievements.ach08Count += 1);
        PlayerPrefs.SetInt("ach09Counter", GlobalAchievements.ach09Count += 1);
        PlayerPrefs.SetInt("ach10Counter", GlobalAchievements.ach10Count += 1);
        //Instantiate(dashSound, transform.position, Quaternion.identity);
        staminaSlider.value -= 5;
        if(regen != null)
        StopCoroutine(regen); //stop regening if dash is used again
        regen = StartCoroutine(RegenStamina());
        yield return new WaitForSeconds(.3f);
        speed -= 20; 
        } else {
            Debug.Log("Not enough stamina");
        }
    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);

        while(staminaSlider.value < staminaSlider.maxValue)
        {
            staminaSlider.value += staminaSlider.maxValue / 100;
            yield return new WaitForSeconds(0.1f);
        }
        regen = null;
    }

}



    /*void ChangeTheSprite ()
    {
        if (spriteRenderer.sprite == character) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = alienCharacter;
        }
        else
        {
            spriteRenderer.sprite = character; // otherwise change it back to sprite1
        }
    }*/


    /*public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    private SpriteRenderer spriteRenderer; 

    void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Space)) // If the space bar is pushed down
        {
            ChangeTheDamnSprite (); // call method to change sprite
        }
    }

    void ChangeTheDamnSprite ()
    {
        if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite2;
        }
        else
        {
            spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
        }
    }
}*/