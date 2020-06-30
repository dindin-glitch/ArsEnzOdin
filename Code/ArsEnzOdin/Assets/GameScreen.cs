﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameScreen : MonoBehaviour {

    public int cooldownMax = 1;
    int cooldownCoeff = 2;
    int cooldownSpeed;
    int cooldown;
    int level = 0;
    public Text levelTexte;
    public Slider cooldownSlider;
    int weapon = 1;
    public Text touchSpeedUp;
    public Text speedDown;
    int gold = 0;
    int luck = 1;
    string weaponName = "knife";
    public Camera mainCamera;
    public Text increaseLuck;
    int tick;
    bool quest;
    bool questCooldown;



    // Use this for initialization
    void Start () {
        cooldownMax = 50 * (level / cooldownCoeff) + 4;
        cooldown = cooldownMax;
        

    }

    //Update is called once per frame.
    void Update () {

        cooldownMax = 50 * (level / ( cooldownCoeff / 4 ) ) + 4;
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
                weaponName = "Weapon number " + weapon;
                break;
        }
        if (quest && cooldown == cooldownMax)
        {
            questCooldown = true;
            gold += luck * level;
            quest = false;
            while (tick != 10)
            {
                tick ++;
            }
            tick = 0;
            questCooldown = false;
        }
        
    }

    //LevelAdd is called when the button quest is hit
    public void LevelAdd () {
        if (cooldown == cooldownMax && !questCooldown) {
            cooldown = 0;
            level +=1;
            quest = true;
        } else {
            
            if (cooldown + weapon < cooldownMax) {
                cooldown += weapon * 10;
            } else {
                cooldown = cooldownMax;
            }
        }
        cooldownMax = 50 * (level / cooldownCoeff) + 4;

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

    
    
    
}