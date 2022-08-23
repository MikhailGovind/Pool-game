using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject ball;
    public TextMeshProUGUI scoreText;
    public static int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + scoreValue;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (scoreValue <= 14)
    //    {
    //        Destroy(ball);
    //        SceneManager.LoadScene(2);
    //    }

    //    if (scoreValue >= 15)
    //    {
    //        Destroy(ball);
    //        SceneManager.LoadScene(3);
    //    }
    //}
}
