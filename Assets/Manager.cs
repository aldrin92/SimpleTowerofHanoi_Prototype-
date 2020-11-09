using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject SubMenu;
    public GameObject InfoMenu;
    public GameObject Wincanvas;
    public GameObject winobject;
    public GameObject Rules;

    public bool iswin = false;
    public bool isPos = false;
    public bool isinfo = false;
    public bool isRules = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(winobject.transform.position == new Vector3(2.842171e-14f, 5.498112f, 10f))
        {
            isPos = true;
        }
        if(isPos == true && iswin == false)
        {
            Wincanvas.SetActive(true);
            Invoke("G_winCanvas",6f);
            isPos = false;
            iswin = true;
        }
        
    }

    public void G_settings()
    {
        SubMenu.SetActive(true);
    }
    public void G_info()
    {
        isinfo =! isinfo;
        InfoMenu.SetActive(isinfo);
    }
    public void G_rules()
    {
        isRules = !isRules;
        Rules.SetActive(isRules);
    }
    public void G_restart()
    {
        SceneManager.LoadScene(1);
    }
    public void G_back()
    {
        SceneManager.LoadScene(0);
    }
    public void G_menuClose()
    {
        SubMenu.SetActive(false);
    }
    public void G_winCanvas()
    {
        
        Wincanvas.SetActive(false);
        G_restart();

    }
    public void quitGame()
    {

        Application.Quit();
    }
}
