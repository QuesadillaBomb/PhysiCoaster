﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsScreenScript : MonoBehaviour
{
    public void LoadResultsScreen()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level1ResultsScreen");
        }

        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            SceneManager.LoadScene("Level2ResultsScreen");
        }

        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            SceneManager.LoadScene("Level3ResultsScreen");
        }
    }
}
