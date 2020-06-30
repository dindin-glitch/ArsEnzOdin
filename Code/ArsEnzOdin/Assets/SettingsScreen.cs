using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : MonoBehaviour {

	public Toggle darkSwitch;
    bool darkBool;
    public Slider darkSlider;
    public Text darkModeLabel;
	public Camera mainCamera;
	public Text levelTexte;


	// Use this for initialization
	void Start () {
		darkSlider.maxValue = 10;
	}
	
	// Update is called once per frame
	void Update () {
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



}
