using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class RecordKeeper : MonoBehaviour
{
    //This script stores infromation from the player who received the highest score.
    
    public static RecordKeeper Instance;
    public string playerInputName;
    public int savedHighestScore;
    public string savedBestPlayer;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadPlayerScore();
    }


    [System.Serializable]
    public class PlayerData
    {
        public string savedBestPlayer;
        public int savedHighestScore;
    }


    public void SavePlayerScore()
    {
        PlayerData data = new PlayerData();
        data.savedBestPlayer = savedBestPlayer;
        data.savedHighestScore = savedHighestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            savedBestPlayer = data.savedBestPlayer;
            savedHighestScore = data.savedHighestScore;
        }
    }
}
