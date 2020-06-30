using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

	public GameObject gamePannel;
    public GameObject settingsPanel;


	// Use this for initialization
	void Start () {
		gamePannel.SetActive(true);
        settingsPanel.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//SettingScreen is called when the player hit the settings button
    public void settingScreen () {
        gamePannel.SetActive(false);
        settingsPanel.SetActive(true);
    }

	//SettingsExit is called when the player hit the exit button
	public void SettingsExit () {
		Start();
	}
	
}
