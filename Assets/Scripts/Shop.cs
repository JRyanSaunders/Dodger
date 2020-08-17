using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static Sprite currentSkin;

    public List<Skin> skins;
    public static int coins;
    public Text coinsDisplay;
    public int id;

    public void Awake()
    {
        if(PlayerPrefs.HasKey("Coins")) {
            coins = PlayerPrefs.GetInt("Coins");
        }
    }

    public void Update()
    {
        coinsDisplay.text = "COINS: " + coins;
    }

    public void DeactivateAllSkins() {
        foreach (var skin in skins) {
            skin.Deactivate();
        }
    }

    public void ResetPucharses() {
        foreach(Skin skin in skins)
        skin.ResetPucharse();
    }

    public void ChangeSkin(Sprite sprite) {
        currentSkin = sprite;
    }

    public void ExitShop()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }
} 



/*    public int coins;
    public int isSkin0Active;
    public bool isSkin1Sold;

    public Text coinsDisplay;
    public Text skin1Price;

    public Button buyButton;
    public Button applyButton;
    public Button resetButton;
    
    private SpriteRenderer spriteRenderer; 

    public static Sprite currentSkin;

    public Sprite skin0;
    public Sprite skin1;

    public void Awake(){
        GetCoins();
        CheckSkinBought();
    }

    public void GetCoins(){
        if(PlayerPrefs.HasKey("Coins")){
        coins = PlayerPrefs.GetInt("Coins");
        }
    }
    
    public void CheckSkinBought(){
        isSkin1Sold = PlayerPrefs.GetInt ("IsSkin1Sold");
    }

    public void UpdateButtons(){
        if(isSkin1Sold)
        buyButton.enabled = false;
        if(isSkin1Active)
        applyButton.enabled = false;
        if(currentSkin != character)
        resetButton.enabled = true;
    }

    public void RestorePurchases(){
        currentSkin = skin0;
        PlayerPrefs.DeleteKey("IsSkin1Sold");
        skin1Price.text = "Price: 5";
        UpdateButtons();
    }

    public void Update(){
        coinsDisplay.text = "COINS: " + coins; 
    }

    public void BuyClick1(){
        if(coins >= 5 && isSkin1Sold == false){
            reduceCoins();
            PlayerPrefs.SetInt("IsSkin1Sold", true);
            skin1Price.text = "Sold!";
            UpdateButtons();
        }
    }

    public void ExitShop(){
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void reduceCoins(){
        coins -= 5;
    }
    
    public void ResetClick() {
        currentSkin = skin;
        PlayerPrefs.SetInt("IsSkin0Active", 1);
        if(isSkin1Sold == 1) {
            PlayerPrefs.DeleteKey("IsSkin0Active");
            UpdateButtons();
        }
    }

    public void ActivateSkin1() {
        currentSkin = skin1;
        UpdateButtons();
    }*/

    // -----------------------------------------------------

    //private int currentSkinId = 0;
    /*public void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(currentSkinId == 0){
                currentSkin = skin1;
                currentSkinId = 1;
            } else if(currentSkinId == 1){
                currentSkin = skin0;
                currentSkinId = 0;
            }
        }
    }*/

    /*public void hasEnoughCoins(){
        if(coins >= 5 && isSkin1Sold == 0){
            buyButton.interactable = true;}
        else {
            buyButton.interactable = false;
            applyButton.interactable = true;
        }
    }*/

/*

    public void ActivateSkin1()
    {
        PlayerPrefs.SetInt("IsSkin1Active", 1);
        applyButton.gameObject.SetActive(false);

        if (isSkin1Active == 1)
        {
            SwitchBetweenSprites();
        }
    }

    void SwitchBetweenSprites ()
    {
        if (spriteRenderer.sprite == character)
        {
            spriteRenderer.sprite = alienCharacter;
        }
        else 
        {
            spriteRenderer.sprite = character; // otherwise change it back to sprite1
        }
    }*/



/* public class ShopControl : MonoBehaviour
{
    public int coins;
    public int isSkin1Sold;

    public Text coinsDisplay;
    public Text skin1Price;

    public Button buyButton;
    public Button activateButton;

    public void Awake()
    {
        if(PlayerPrefs.HasKey("Coins"))
        {
        coins = PlayerPrefs.GetInt("Coins");
        }
    }

        public void Update()
    {
        coinsDisplay.text = "COINS: " + coins;

        isSkin1Sold = PlayerPrefs.GetInt ("IsSkin1Sold");

        if(coins >= 5 && isSkin1Sold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false; 
    }

    public void BuySkin1()
    {
        coins -= 5;
        PlayerPrefs.SetInt("IsSkin1Sold", 1);
        skin1Price.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }

    public void ExitShop()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void ResetPlayerPrefs()
    {
        buyButton.gameObject.SetActive(true);
        skin1Price.text = "Price: 5";
        PlayerPrefs.DeleteKey("IsSkin1Sold");
    }
} */