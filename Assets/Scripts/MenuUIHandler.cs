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
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName()
    {
        RecordKeeper.Instance.playerInputName = playerNameInput.text;

    }




    public void StartGame()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
        
    }

    public void ReturnMenu()
    {
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
