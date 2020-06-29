using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Main : MonoBehaviour {

    public int cooldownMax = 1;
    public int cooldownCoeff = 2;
    public int cooldownSpeed;
    public int cooldown;
    public int level = 0;
    public Text levelTexte;
    public Slider cooldownSlider;
    public int weapon = 1;
    public Text touchSpeedUp;
    public Text speedDown;
    public int gold = 0;
    public int luck = 1;
    public string weaponName = "knife";
    public Camera mainCamera;
    public Toggle darkSwitch;
    public bool darkBool;
    public Slider darkSlider;
    public Text darkModeLabel;
    public Text increaseLuck;

    // Use this for initialization
    void Start () {
        cooldownMax = 50 * (level / cooldownCoeff) + 4;
        cooldown = cooldownMax;
        darkSlider.maxValue = 10;

    }

    //Update is called once per frame.
    void Update () {
        cooldownMax = 50 * (level / cooldownCoeff) + 4;
        cooldownSlider.maxValue = cooldownMax;
        levelTexte.text = ("Level : " + level + "\n Gold: " + gold);
        if (cooldown < cooldownMax) {
            cooldown += 1;
        }
        cooldownSlider.value = cooldown;
        speedDown.text = ("Go to fitness : " + (cooldownCoeff * 4) + " gold \n Went : " + cooldownCoeff);
        touchSpeedUp.text = ("Buy weapon : " + (weapon * 5) + " gold \n Buyed : " + weaponName);
        increaseLuck.text = ("Go to lottery : " + (luck * 7) + " gold \n Went : " + luck);
        switch (weapon)
        {
            case 1:
                weaponName = "knife";
                break;
            case 2:
                weaponName = "slingshot";
                break;
            case 3:
                weaponName = "gun";
                break;
            case 4:
                weaponName = "revolver";
                break;
            default:
                
                break;
        }
        if (darkBool) {
            if (darkSlider.value !=10) {
                darkSlider.value += 1;
            }
        } else {
            if (darkSlider.value != 0) {
                darkSlider.value -= 1;
            }
        }
        if (darkSwitch.isOn == true) {
            mainCamera.backgroundColor = Color.black;
            darkBool = true;
            darkModeLabel.color = Color.white;
            levelTexte.color = Color.white;
        } else {
            mainCamera.backgroundColor = Color.grey;
            darkBool = false;
            darkModeLabel.color = Color.black;
            levelTexte.color = Color.black;
        }
        
    }

    //LevelAdd is called when the button quest is hit
    public void LevelAdd () {
        if (cooldown == cooldownMax) {
            level +=1;
            gold += luck * level;
            cooldown = 0;
        } else {
            if (cooldown + weapon < cooldownMax) {
                cooldown += weapon;
            } else {
                cooldown = cooldownMax;
            }
        }

    }

    //StoreSpeed is called when the character go to fitness
    public void storeSpeed () {
        
        if (gold >= cooldownCoeff * 4) {
            cooldownCoeff += 1;
            gold -= cooldownCoeff * 4;
        }
    }

    //StoreTouch is called when the player buy a weapon
    public void storeTouch () {

        if (gold >= weapon * 5) {
            gold -= weapon * 5;
            weapon += 1;

        }
    }

    //StoreLuck is called when the character go to lottery
    public void storeLuck () {
        if (gold >= luck * 7) {
            gold -= luck *7;
            luck ++;
            
        }
    }
    
    //SettingScreen is called when the player hit the settings button
    public void settingScreen () {
        //Place here the code
    }
}