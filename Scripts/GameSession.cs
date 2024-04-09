using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{

    public Text scoreText;

    int currentScore;

    //private void Awake()
    //{
    //    int instanceCount = FindObjectsOfType<GameSession>().Length;
    //    if(instanceCount > 1)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}

    void Update()
    {
           scoreText.text = currentScore.ToString();
        
    }

    public void IncreaseScore(int value)
    {
        currentScore += value;
    }

}
