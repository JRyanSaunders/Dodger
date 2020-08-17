using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skin : MonoBehaviour
{
  private bool isActive = false;
  private bool isBought = false;
  
  public Sprite skin;
  public Image image;
  public Text text;
  public Text coinsDisplay;

  public int skinPrice;
  public int id;
  public static int coins;
  //public TextMeshProUGUI text;

  public Button activateBtn;
  public Button buyBtn;

  public Shop shop;

  void Awake() {
    GetCoins();
    CheckSkinBought();
    CheckSkinActive();
    ActivateSkinActive();
  }

  public void GetCoins(){
    if(PlayerPrefs.HasKey("Coins")){
      coins = PlayerPrefs.GetInt("Coins");
    }
  }

  void CheckSkinBought(){
      string prefName = id+"_isBought";
      if(PlayerPrefs.HasKey(prefName)) {
        isBought = PlayerPrefsX.GetBool(prefName);
      }
      else
        isBought = false;
  }

  void CheckSkinActive(){
      string prefName = id+"_isActive";
      if(PlayerPrefs.HasKey(prefName)) {
        isActive = PlayerPrefsX.GetBool(prefName);
      }
      else
        isActive = false;
    }

    void ActivateSkinActive(){
      if(isActive == true) {
        Activate();
      }
    }

  void Start()
  {
    if(buyBtn != null)
      buyBtn.onClick.AddListener(Buy);
    if(activateBtn != null) 
      activateBtn.onClick.AddListener(Activate);
      UpdateLook();
  }

  void Buy() {
    if(coins >= skinPrice){
      PlayerPrefsX.SetBool(id + "_isBought", true);
      PlayerPrefs.SetInt("Coins", coins);
      isBought = true;
      reduceCoins();
      Activate();
    }
  }

  public void Update(){
    coinsDisplay.text = "COINS: " + coins; 
  }

  // Update is called once per frame
  public void UpdateLook()
  {
    if(!isBought) { //Code to execute if skin is not bought
        text.text = "Price: $1500";
        image.color = Color.black;

        activateBtn.interactable = false;
        buyBtn.interactable = true;
    } else if(!isActive) { //Code to execute if skin is bought but not active
        text.text = "Activate skin!"; 
        image.color = Color.red;

        buyBtn.interactable = false;
        activateBtn.interactable = true;
    } else { //Code to execute if skin is bought and active
        text.text = "Activated!";
        image.color = Color.green;

        buyBtn.interactable = false;
        activateBtn.interactable = false;
    }
  }

  public void reduceCoins(){
    coins -= 5;
  }

  public void Activate() {
    shop.DeactivateAllSkins();
    shop.ChangeSkin(skin);
    PlayerPrefsX.SetBool(id + "_isActive", true);
    isActive = true;
    UpdateLook();
  }

  public void Deactivate() {
    PlayerPrefsX.SetBool(id + "_isActive", false);
    isActive = false;
    UpdateLook();
  }

    public void BackButton()
    {
      PlayerPrefs.SetInt("Coins", coins);
    }

    public void ResetPucharse() {
      PlayerPrefsX.SetBool(id+"_isBought", false);
      PlayerPrefsX.SetBool(id+"_isActive", false);
      isBought = false;
      isActive = false;
      UpdateLook();
  }
}

  //Debug.Log($"Is bought: {isBought}");
  //Debug.Log($"Is bought: {isActive}"); This is called stack trace