﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    enum Cursor { Select, Cultify, Sacrifice, Obelisk, Day, Night};
    Cursor myCursor;
    bool day;
    public Sprite dayImage, nightImage;
    public Button dayNightButton;


	// Use this for initialization
	void Start () {
        day = true;
        myCursor = Cursor.Select;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Select()
    {
        myCursor = Cursor.Select;
        Debug.Log(myCursor);
    }

    void Cultify()
    {
        myCursor = Cursor.Cultify;
        Debug.Log(myCursor);
    }

    void Sacrifice()
    {
        myCursor = Cursor.Sacrifice;
        Debug.Log(myCursor);
    }

    void Obelisk()
    {
        myCursor = Cursor.Obelisk;
        Debug.Log(myCursor);
    }

    void DayNight()
    {   
        if(day)
        {
            myCursor = Cursor.Day;
            dayNightButton.GetComponent<Image>().sprite = nightImage;
            day = false;
        }
        else
        {
            myCursor = Cursor.Night;
            dayNightButton.GetComponent<Image>().sprite = dayImage;
            day = true;
        }

        Debug.Log(myCursor);
    }

    Cursor GetCursor()
    {
        return myCursor;
    }
}