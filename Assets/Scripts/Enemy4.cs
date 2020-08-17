using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy4 : MonoBehaviour
{
    public float speed;
    public GameObject effect;
    public int health;
    public int score = 0;
    public GameObject edamagesound;
    public GameObject pdamagesound;
    public GameObject E2DeathEffect;
    public int hp;
    public GameObject floatingPoints;
    public GameObject floatingPoints5;
    public GameObject floatingMinusPoints;
    public GameObject Enemy5;

    private Shake shake;
    private Transform playerPos; 
    private Player player; //have to create a reference to player to refer to

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>(); //find the object with tag player and get the player script
        playerPos = GameObject.FindGameObjectWithTag("Player").transform; //this is how it finds player with tag and gets transform which stores object position, rotation, scale
        
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime); // enemy position (transform.position) looks for player
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Instantiate(effect, transform.position, Quaternion.identity);
            //Instantiate(pdamagesound, transform.position, Quaternion.identity);
            //FindObjectOfType<AudioManager>().Play("PDamageSound");
            AudioManager.instance.Play("PDamageSound");
            Instantiate(floatingMinusPoints, transform.position, Quaternion.identity);
            Destroy(gameObject);
            shake.CamShake();
            player.healthSlider.value--;
            player.health--; //player loses 1 health point on collision
            //Debug.Log(player.health);
        }

        if(other.CompareTag("Projectile")){
            //Instantiate(edamagesound, transform.position, Quaternion.identity);
            //FindObjectOfType<AudioManager>().Play("EDamageSound");
            AudioManager.instance.Play("EDamageSound");
            Destroy(other.gameObject);
            shake.CamShake();
            if(hp == 0){
            Instantiate(Enemy5, transform.position, Quaternion.identity);
            Instantiate(E2DeathEffect, transform.position, Quaternion.identity);
            Instantiate(floatingPoints, transform.position, Quaternion.identity);
            GameManager.instance.AddScore();}
            //player.score++;
            //Debug.Log(player.score);
        }

    }
}
