using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]


public class MenuUIHandler : MonoBehaviour
{
    public MainManager manager;

    public void StoreUserName(string name)
    {
        NewMainManager.Instance.input = name;
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    
    }

   

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Return()
    {
        
        SceneManager.LoadScene(0);
        
        
    }

}
