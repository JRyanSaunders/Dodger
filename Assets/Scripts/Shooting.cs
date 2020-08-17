using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    
    public GameObject shot; // Project tile player is shooting
    private Transform playerPos; // reference to the player
    //public GameObject bulletsound;

    public static bool ShootingIsActive = true;

    void Start() {
        playerPos = GetComponent<Transform>();
    }

    void Update() {
        if(ShootingIsActive == true)
        {
            if(Input.GetMouseButtonDown(0)) { // checking if we click mouse button. 0 is left click 1 is middle click 2 is right click
                Instantiate(shot, playerPos.position, Quaternion.identity); //spawns shot at the players position with no rotation
                //FindObjectOfType<AudioManager>().Play("BulletSound");
                AudioManager.instance.Play("BulletSound");
                //Instantiate(bulletsound, transform.position, Quaternion.identity);
            }
        }
    }

}
