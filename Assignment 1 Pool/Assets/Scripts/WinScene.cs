using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Score.scoreValue < 15)
        //{
        //    SceneManager.LoadScene(2);
        //}

        if (Score.scoreValue >= 15)
        {
            SceneManager.LoadScene(3);
        }
    }
}
