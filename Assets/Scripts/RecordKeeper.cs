using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordKeeper : MonoBehaviour
{
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
    }




    void Start()
    {
        savedHighestScore = 0;
        savedBestPlayer = "";


    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
