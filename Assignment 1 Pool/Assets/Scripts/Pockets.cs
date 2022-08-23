using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pockets : MonoBehaviour
{
    //public GameObject ball;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Score.scoreValue += 1;
    //    Destroy(ball);
    //}

    public GameObject ball;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score.scoreValue += 1;
        Destroy(ball);
    }
}
