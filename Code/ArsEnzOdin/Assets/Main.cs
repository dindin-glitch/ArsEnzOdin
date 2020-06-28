using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class Main : MonoBehaviour {
    
    public int level = 0;
    public Text levelTexte;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        levelTexte.text = ("Level: " + level);
    }
    public void LevelAdd () {
        level += 1;
        
        
    }
    
=======


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
    public Button touchSpeedUpButton;
    public Text speedDown;
    public int gold = 0;
    public int luck = 1;
    public string weaponName = "knife";

    // Use this for initialization
    void Start () {
        cooldownMax = 50 * (level / cooldownCoeff) + 4;
        cooldown = cooldownMax;

    }

    //Update is called once per frame.
    void Update () {
        cooldownMax = 50 * (level / cooldownCoeff) + 4;
        cooldownSlider.maxValue = cooldownMax;
        levelTexte.text = ("Gold: " + gold);
        if (cooldown < cooldownMax) {
            cooldown += 1;
        }
        cooldownSlider.value = cooldown;
        speedDown.text = ("Go to fitness : " + (cooldownCoeff * 4) + " gold \n Went : " + cooldownCoeff);
        touchSpeedUp.text = ("Buy weapon : " + (weapon * 5) + " gold \n Buyed : " + weaponName);
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
                weaponName = "GG, you found a bug! Please report it with the report menu!";
                break;
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
>>>>>>> Odin
}