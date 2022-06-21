using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        LoadHighScoreJSON();
    }
    
    [System.Serializable]
    class SaveData
    {
        public string input;
        public string HighScoreSave;
        public int highscore;
    }

    public void SaveHighScoreJSON()
    {
        SaveData data = new SaveData();
        data.input = input;
        data.HighScoreSave = HighScoreSave;
        data.highscore = highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScoreJSON()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            input = data.input;
            HighScoreSave = data.HighScoreSave;
            highscore = data.highscore;
        }
    }
}
