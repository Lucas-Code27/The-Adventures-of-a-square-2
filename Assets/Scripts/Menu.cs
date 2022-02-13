﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Classicmode()
    {
        SceneManager.LoadScene("Classic Mode");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Level 7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("Level 8");
    }
    public void Level9()
    {
        SceneManager.LoadScene("Level 9");
    }
    public void Level10()
    {
        SceneManager.LoadScene("Level 10");
    }
}
