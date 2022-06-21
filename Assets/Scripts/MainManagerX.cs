using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManagerX : MonoBehaviour
{

    public static MainManagerX Instance;
    public TextMeshProUGUI playerName;

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
