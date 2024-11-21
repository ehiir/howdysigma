using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public GameObject menuPanel;
    public Movement playerMovement;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            menuPanel.SetActive(!menuPanel.activeSelf);
        }
    }
    public void NewGame()
    {
        new SaveData();
    }


    public void Continue()
    {

    }

    public void Exit()
    {

    }

    public void Save()
    {
        playerMovement.Save();
        DataSerializer.Save();
    
    }
}