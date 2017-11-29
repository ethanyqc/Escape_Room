using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispUI_yqc : MonoBehaviour {

    public string str;
    public Text txt;
    public float fadeTime;
    public bool displayInfo;

	// Use this for initialization
	void Start () {
        txt = GetComponentInChildren<Text>();
        txt.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
        FadeText();
	}

    void OnMouseOver(){
        displayInfo = true;
    }
    void OnMouseExit(){
        displayInfo = false;
    }
    void FadeText(){
        if (displayInfo)
        {
            txt.text = str;
            txt.color = Color.Lerp(txt.color, Color.white, fadeTime * Time.deltaTime);
        }
        else txt.color = Color.Lerp(txt.color, Color.clear, fadeTime * Time.deltaTime);
    }



}
