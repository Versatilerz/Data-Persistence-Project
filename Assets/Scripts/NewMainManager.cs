using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewMainManager : MonoBehaviour
{
    public static NewMainManager Instance;
    public string input;
    public string HighScoreSave;
    public int highscore;
    
   

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

   
}
