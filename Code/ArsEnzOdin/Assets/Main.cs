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
    public int touchCoeff = 1;
    public Text touchSpeedUp;
    public Text speedDown;
    public int gold = 0;
    public int luck = 1;

    // Use this for initialization
    void Start () {
        
    }

    //Update is called once per frame.
    void Update () {
        cooldownMax = 50 * (level / cooldownCoeff);
        cooldownSlider.maxValue = cooldownMax;
        levelTexte.text = ("Gold: " + gold);
        if (cooldown < cooldownMax) {
            cooldown += 1;
        }
        cooldownSlider.value = cooldown;
    }
    public void LevelAdd () {
        if (cooldown == cooldownMax) {
            level +=1;
            gold += luck * level;
            cooldown = 0;
        } else {
            if (cooldown + touchCoeff < cooldownMax) {
                cooldown += touchCoeff;
            } else {
                cooldown = cooldownMax;
            }
        }

    }
    public void storeSpeed () {
        cooldownCoeff += 1;
        speedDown.text = ("Go to fitness : " + (cooldownCoeff * 4) + " gold \n Went : " + cooldownCoeff);

    }
    public void storeTouch () {

        touchSpeedUp.text = ("Better weapon : " + (touchCoeff * 5) + " gold \n Buyed : " + touchCoeff);
        if (gold >= touchCoeff * 5) {
            gold -= touchCoeff * 5;
            touchCoeff += 1;

        }
    }
}