﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
    public int curLevel = 0;
    private List<bool> curSolutions = new List<bool>();

    public GameLevels gameLevels;

    void Start()
    {
        gameLevels.Initialise();

        curSolutions = gameLevels.CurrentStage(curLevel);
        /*foreach(bool b in curSolutions)
        {
            Debug.Log(b);
        }*/
    }

    public bool IsCorrect(List<bool> c) //Tests *c*hoices against solutions
    {
        for(int i = 0; i < curSolutions.Count; i++)
        {
            if (curSolutions[i] != c[i])
            {
                return false;
            }
        }

        return true; //At this point we've checked both lists and can confirm it's correct
    }
}