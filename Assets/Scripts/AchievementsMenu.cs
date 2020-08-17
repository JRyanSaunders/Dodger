using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AchievementsMenu : MonoBehaviour
{
    public static int ach01Count;
    public static int ach01Code;

    public static int ach02Count;
    public static int ach02Code;

    public static int ach03Count;
    public static int ach03Code;

    public static int ach04Count;
    public static int ach04Code;

    public static int ach05Count;
    public static int ach05Code;
    
    public static int ach06Count;
    public static int ach06Code;

    public static int ach07Count;
    public static int ach07Code;

    public static int ach08Count;
    public static int ach08Code;

    public static int ach09Count;
    public static int ach09Code;

    public static int ach10Count;
    public static int ach10Code;

    public Button AchResetButton;

    public void Awake()
    {
        if(GlobalAchievements.ach01Code == 01 || GlobalAchievements.ach02Code == 02 || GlobalAchievements.ach03Code == 03 || GlobalAchievements.ach04Code == 04 || GlobalAchievements.ach05Code == 05 
        || GlobalAchievements.ach06Code == 06 || GlobalAchievements.ach07Code == 07 || GlobalAchievements.ach08Code == 08 || GlobalAchievements.ach09Code == 09 || GlobalAchievements.ach10Code == 10) 
        {
            AchResetButton.interactable = true;
        } else {
            AchResetButton.interactable = false;
        }
    }

    // Start is called before the first frame update

    public void AchReset()
    {
        if(GlobalAchievements.ach01Code == 01) {
            GlobalAchievements.ach01Count = 0;
            PlayerPrefs.DeleteKey("ach01Counter");
            //PlayerPrefs.SetInt("ach01Counter", GlobalAchievements.ach01Count);
            GlobalAchievements.ach01Code = 0;
            PlayerPrefs.SetInt("Ach01", GlobalAchievements.ach01Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach02Code == 02) {
            GlobalAchievements.ach02Count = 0;
            PlayerPrefs.DeleteKey("ach02Counter");
            //PlayerPrefs.SetInt("ach02Counter", GlobalAchievements.ach02Count);
            GlobalAchievements.ach02Code = 0;
            PlayerPrefs.SetInt("Ach02", GlobalAchievements.ach02Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach03Code == 03) {
            GlobalAchievements.ach03Count = 0;
            PlayerPrefs.DeleteKey("ach03Counter");
            //PlayerPrefs.SetInt("ach03Counter", GlobalAchievements.ach03Count);
            GlobalAchievements.ach03Code = 0;
            PlayerPrefs.SetInt("Ach03", GlobalAchievements.ach03Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach04Code == 04) {
            GlobalAchievements.ach04Count = 0;
            PlayerPrefs.DeleteKey("ach04Counter");
            //PlayerPrefs.SetInt("ach04Counter", GlobalAchievements.ach04Count);
            GlobalAchievements.ach04Code = 0;
            PlayerPrefs.SetInt("Ach04", GlobalAchievements.ach04Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach05Code == 05) {
            GlobalAchievements.ach05Count = 0;
            GlobalAchievements.ach05Code = 0;
            PlayerPrefs.SetInt("Ach05", GlobalAchievements.ach05Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach06Code == 06) {
            GlobalAchievements.ach06Count = 0;
            GlobalAchievements.ach06Code = 0;
            PlayerPrefs.SetInt("Ach06", GlobalAchievements.ach06Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach07Code == 07) {
            GlobalAchievements.ach07Count = 0;
            GlobalAchievements.ach07Code = 0;
            PlayerPrefs.SetInt("Ach07", GlobalAchievements.ach07Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach08Code == 08) {
            GlobalAchievements.ach08Count = 0;
            PlayerPrefs.DeleteKey("ach08Counter");
            GlobalAchievements.ach08Code = 0;
            PlayerPrefs.SetInt("Ach08", GlobalAchievements.ach08Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach09Code == 09) {
            GlobalAchievements.ach09Count = 0;
            PlayerPrefs.DeleteKey("ach09Counter");
            GlobalAchievements.ach09Code = 0;
            PlayerPrefs.SetInt("Ach09", GlobalAchievements.ach09Code);
            AchResetButton.interactable = false;
        }

        if(GlobalAchievements.ach10Code == 10) {
            GlobalAchievements.ach10Count = 0;
            PlayerPrefs.DeleteKey("ach10Counter");
            GlobalAchievements.ach10Code = 0;
            PlayerPrefs.SetInt("Ach10", GlobalAchievements.ach10Code);
            AchResetButton.interactable = false;
        }

    }
}
