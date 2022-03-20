using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
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
