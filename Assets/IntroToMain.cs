using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroToMain : MonoBehaviour
{
    public void GotoGame()
    {
        SceneManager.LoadScene(1);
    }


}
