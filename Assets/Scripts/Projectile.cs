using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Vector2 target;
    public float speed;
    public GameObject enemy;
    public GameObject bulletEffect;
    public GameObject Enemy2;
    public int highScore;

    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition); // as soon as the target varaible spawns it will be equal to the cursors position
    }

    
        void Update(){
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); // gets project tile moving to that target position
        if(Vector2.Distance(transform.position, target) < 0.2f){ //checking distance between current position and target position
            Instantiate(enemy, transform.position, Quaternion.identity); //spawns an enemy with no rotation
            Destroy(gameObject);
        }  
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Enemy")){
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
        if(other.CompareTag("Enemy2")) {
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy2 enemy = other.GetComponent<Enemy2>();
            enemy.hp--;
            if(enemy.hp == 0)
            Destroy(enemy.gameObject);
        }
        if(other.CompareTag("Enemy3")){
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy3 enemy = other.GetComponent<Enemy3>();
            enemy.hp--;
            if(enemy.hp == 0)
            Destroy(enemy.gameObject); 
        }

        if(other.CompareTag("Enemy4")){
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy4 enemy = other.GetComponent<Enemy4>();
            enemy.hp--;
            if(enemy.hp == 0)
            Destroy(enemy.gameObject); 
        }

        if(other.CompareTag("Enemy5")){
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy5 enemy = other.GetComponent<Enemy5>();
            enemy.hp--;
            if(enemy.hp == 0)
            Destroy(enemy.gameObject); 
        }

        if(other.CompareTag("Enemy")){
            PlayerPrefs.SetInt("ach01Counter", GlobalAchievements.ach01Count += 1);
            PlayerPrefs.SetInt("ach02Counter", GlobalAchievements.ach02Count += 1);
            PlayerPrefs.SetInt("ach03Counter", GlobalAchievements.ach03Count += 1);
            PlayerPrefs.SetInt("ach04Counter", GlobalAchievements.ach04Count += 1);
        }
        if(other.CompareTag("Enemy2")){
            PlayerPrefs.SetInt("ach01Counter", GlobalAchievements.ach01Count += 1);
            PlayerPrefs.SetInt("ach02Counter", GlobalAchievements.ach02Count += 1);
            PlayerPrefs.SetInt("ach03Counter", GlobalAchievements.ach03Count += 1);
            PlayerPrefs.SetInt("ach04Counter", GlobalAchievements.ach04Count += 1);
        }
    }    
}  
