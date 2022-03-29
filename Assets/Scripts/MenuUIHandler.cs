using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    //This is the handler of the main menu scene

    public InputField playerNameInput;
    public TextMeshProUGUI bestPlayerMenuScreen;

    void Start()
    {
        DisplayBestPlayer();
    }

    public void SetPlayerName()
    {
        RecordKeeper.Instance.playerInputName = playerNameInput.text;
    }

    public void DisplayBestPlayer()
    {
        bestPlayerMenuScreen.text = $"Best Score: {RecordKeeper.Instance.savedBestPlayer} {RecordKeeper.Instance.savedHighestScore}";
    }


    public void StartGame()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void ReturnMenu()
    {
        RecordKeeper.Instance.SavePlayerScore();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
