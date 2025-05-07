using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MenuHandler : MonoBehaviour
{
    public TMP_InputField InputName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(0);
        
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void AssignTheName(string playerName)
    {
        
        Debug.Log("AssignTheName called with: " + playerName);
        if (!string.IsNullOrEmpty(playerName))
        {
            SaveData.Instance.playerName = playerName;
            Debug.Log("Player name set to: " + playerName);
        }
    }
}
