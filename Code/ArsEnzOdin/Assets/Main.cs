using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    
}