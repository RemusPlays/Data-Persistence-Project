using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordKeeper : MonoBehaviour
{
    public static RecordKeeper Instance;
    public string playerInputName;

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


}
