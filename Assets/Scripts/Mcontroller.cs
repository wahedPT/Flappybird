using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mcontroller : MonoBehaviour
{

    public GameObject optionPanel;
    public GameObject menuPanel;
    public GameObject HelpPanel;
   

    public void optionmenu()
    {
        optionPanel.SetActive(true);
       menuPanel.SetActive(false);
       HelpPanel.SetActive(false);
    }
   
    public void Helpmenu()
    {
        optionPanel.SetActive(false);
        menuPanel.SetActive(false);
        HelpPanel.SetActive(true);
    }

    public void Back()
    {
        optionPanel.SetActive(false);
        menuPanel.SetActive(true);
        HelpPanel.SetActive(false);
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(1);
        optionPanel.SetActive(false);
        menuPanel.SetActive(false);
        HelpPanel.SetActive(false);
    }

}
