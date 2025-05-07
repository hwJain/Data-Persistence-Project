using UnityEngine;
using System.IO;
using System.Runtime.InteropServices;

public class SaveData : MonoBehaviour
{
    public string playerName;
    public int bestScores;
    public static SaveData Instance;
    //public string Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadTheData();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    [System.Serializable]
    class SavetheData
    {
        public string playerName;
        public int bestScores;
    }


    public void SaveTheData()
    {
        SavetheData data = new SavetheData();
        data.playerName = playerName;
        data.bestScores = bestScores;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadTheData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SavetheData data = JsonUtility.FromJson<SavetheData>(json);

            playerName = data.playerName;
            bestScores = data.bestScores;

        }
        else
        {
            // No file found, set default values
            playerName = "No Player";
            bestScores = 0;
        }
    }
}

