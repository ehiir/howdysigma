using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public GameObject menuPanel;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            menuPanel.SetActive(!menuPanel.activeSelf);
        }
    }
    public void NewGame()
    {

    }


    public void Continue()
    {

    }

    public void Exit()
    {

    }

    public void Save()
    { 
    
    
    
    }
}