using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //General variable
    public GameObject achNote;
    //public AudioSource achSound;
    public GameObject achTitle;
    public GameObject achDesc;

    //Achievement specific
    public static int highScore;

    //Achievement 01 specific
    public GameObject ach01Image;
    public static int ach01Count;
    public int ach01Trigger;
    public static int ach01Code;
    public static bool ach1Active = false;

    //Achievement 02 specific
    public GameObject ach02Image;
    public static int ach02Count;
    public int ach02Trigger;
    public static int ach02Code;
    public static bool ach2Active = false;

    //Achievement 03 specific
    public GameObject ach03Image;
    public static int ach03Count;
    public int ach03Trigger;
    public static int ach03Code;
    public static bool ach3Active = false;

    //Achievement 04 specific
    public GameObject ach04Image;
    public static int ach04Count;
    public int ach04Trigger;
    public static int ach04Code;
    public static bool ach4Active = false;

    //Achievement 05 specific
    public GameObject ach05Image;
    public static int ach05Count;
    public int ach05Trigger;
    public static int ach05Code;
    public static bool ach5Active = false;

    //Achievement 06 specific
    public GameObject ach06Image;
    public static int ach06Count;
    public int ach06Trigger;
    public static int ach06Code;
    public static bool ach6Active = false;

    
    //Achievement 07 specific
    public GameObject ach07Image;
    public static int ach07Count;
    public int ach07Trigger;
    public static int ach07Code;
    public static bool ach7Active = false;

    //Achievement 08 specific
    public GameObject ach08Image;
    public static int ach08Count;
    public int ach08Trigger;
    public static int ach08Code;
    public static bool ach8Active = false;

    //Achievement 09 specific
    public GameObject ach09Image;
    public static int ach09Count;
    public int ach09Trigger;
    public static int ach09Code;
    public static bool ach9Active = false;

    
    //Achievement 10 specific
    public GameObject ach10Image;
    public static int ach10Count;
    public int ach10Trigger;
    public static int ach10Code;
    public static bool ach10Active = false;

    void Update()
    {
        ach01Code = PlayerPrefs.GetInt("Ach01");
        ach02Code = PlayerPrefs.GetInt("Ach02");
        ach03Code = PlayerPrefs.GetInt("Ach03");
        ach04Code = PlayerPrefs.GetInt("Ach04");
        ach05Code = PlayerPrefs.GetInt("Ach05");
        ach06Code = PlayerPrefs.GetInt("Ach06");
        ach07Code = PlayerPrefs.GetInt("Ach07");
        ach08Code = PlayerPrefs.GetInt("Ach08");
        ach09Code = PlayerPrefs.GetInt("Ach09");
        ach10Code = PlayerPrefs.GetInt("Ach10");

        ach01Count = PlayerPrefs.GetInt("ach01Counter");
        ach02Count = PlayerPrefs.GetInt("ach02Counter");
        ach03Count = PlayerPrefs.GetInt("ach03Counter");
        ach04Count = PlayerPrefs.GetInt("ach04Counter");
        ach08Count = PlayerPrefs.GetInt("ach08Counter");
        ach09Count = PlayerPrefs.GetInt("ach09Counter");
        ach10Count = PlayerPrefs.GetInt("ach10Counter");

        if(ach01Count >= ach01Trigger && ach01Code != 01) 
        {
            StartCoroutine(Trigger01Ach());
        }

        if(ach02Count >= ach02Trigger && ach02Code != 02) 
        {
            StartCoroutine(Trigger02Ach());
        }

        if(ach03Count >= ach03Trigger && ach03Code != 03) 
        {
            StartCoroutine(Trigger03Ach());
        }

        if(ach04Count >= ach04Trigger && ach04Code != 04) 
        {
            StartCoroutine(Trigger04Ach());
        }

        if(ach05Count >= ach05Trigger && ach05Code != 05) 
        {
            StartCoroutine(Trigger05Ach());
        }           

        if(ach06Count >= ach06Trigger && ach06Code != 06) 
        {
            StartCoroutine(Trigger06Ach());
        }

        if(ach07Count >= ach07Trigger && ach07Code != 07) 
        {
            StartCoroutine(Trigger07Ach());
        } 

        if(ach08Count >= ach08Trigger && ach08Code != 08) 
        {
            StartCoroutine(Trigger08Ach());
        }           

        if(ach09Count >= ach09Trigger && ach09Code != 09) 
        {
            StartCoroutine(Trigger09Ach());
        }

        if(ach10Count >= ach10Trigger && ach10Code != 10) 
        {
            StartCoroutine(Trigger10Ach());
        }                   
    }

    IEnumerator Trigger01Ach()
    {
        ach1Active = true;
        ach01Code = 01;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach01Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "KILLER!";
        achDesc.GetComponent<Text>().text = "Kill a total of 100 enemies.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach01Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach1Active = false;
    }

    IEnumerator Trigger02Ach()
    {
        ach2Active = true;
        ach02Code = 02;
        PlayerPrefs.SetInt("Ach02", ach02Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach02Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "ASSASSIN!";
        achDesc.GetComponent<Text>().text = "Kill a total of 1000 enemies.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach02Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach2Active = false;
    }

    IEnumerator Trigger03Ach()
    {
        ach3Active = true;
        ach03Code = 03;
        PlayerPrefs.SetInt("Ach03", ach03Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach03Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "WARRIOR!";
        achDesc.GetComponent<Text>().text = "Kill a total of 10,000 enemies.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach03Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach3Active = false;
    }

    IEnumerator Trigger04Ach()
    {
        ach4Active = true;
        ach04Code = 04;
        PlayerPrefs.SetInt("Ach04", ach04Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach04Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "GOD!";
        achDesc.GetComponent<Text>().text = "Kill a total of 100,0000 enemies.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach04Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach4Active = false;
    }

    IEnumerator Trigger05Ach()
    {
        ach5Active = true;
        ach05Code = 05;
        PlayerPrefs.SetInt("Ach05", ach05Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach05Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "KILLSTREAK!";
        achDesc.GetComponent<Text>().text = "Achieve a High Score of 200.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach05Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach5Active = false;
    }

    IEnumerator Trigger06Ach()
    {
        ach6Active = true;
        ach06Code = 06;
        PlayerPrefs.SetInt("Ach06", ach06Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach06Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "APOCALYPSE!";
        achDesc.GetComponent<Text>().text = "Achieve a High Score of 300.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach06Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach6Active = false;
    }

    IEnumerator Trigger07Ach()
    {
        ach7Active = true;
        ach07Code = 07;
        PlayerPrefs.SetInt("Ach07", ach07Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach07Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "THE END!?";
        achDesc.GetComponent<Text>().text = "Achieve a High Score of 500.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach07Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach7Active = false;
    }

    IEnumerator Trigger08Ach()
    {
        ach8Active = true;
        ach08Code = 08;
        PlayerPrefs.SetInt("Ach08", ach08Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach08Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "GREASY!";
        achDesc.GetComponent<Text>().text = "Dash a total of 25 times.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach08Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach8Active = false;
    }

    IEnumerator Trigger09Ach()
    {
        ach9Active = true;
        ach09Code = 09;
        PlayerPrefs.SetInt("Ach09", ach09Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach09Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "SLIMEY!";
        achDesc.GetComponent<Text>().text = "Dash a total of 250 times.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach09Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach9Active = false;
    }

    IEnumerator Trigger10Ach()
    {
        ach10Active = true;
        ach10Code = 10;
        PlayerPrefs.SetInt("Ach10", ach10Code);
        //FindObjectOfType<AudioManager>().Play("AchievementSound");
        AudioManager.instance.Play("AchievementSound");
        //achSound.Play();
        ach10Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "THE END!";
        achDesc.GetComponent<Text>().text = "Dash a total of 1,000 times.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Reseting UI
        achNote.SetActive(false);
        ach10Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        ach10Active = false;
    }
}
