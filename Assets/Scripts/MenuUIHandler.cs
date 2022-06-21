using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]


public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
  
    public void NewPlayer(TextMeshProUGUI name)
    {
        MainManagerX.Instance.playerName = name;
    }


    






















    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }

}
