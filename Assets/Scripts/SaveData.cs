using UnityEngine;
using System.IO;

public class SaveData : MonoBehaviour
{
    public string playerName;
    public int bestScore;
    public static SaveData Instance;
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
        public int bestScore;
    }


    public void SaveTheData()
    {
        SavetheData data= new SavetheData();
        data.playerName= playerName;
        data.bestScore= bestScore;
    }

    public void LoadTheData()
    {

    }
}
