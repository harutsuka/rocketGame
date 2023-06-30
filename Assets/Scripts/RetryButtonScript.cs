using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RetryButtonScript : MonoBehaviour
{
    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score != 0)
        {
            Debug.Log(score);
        }
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1.0f;
        score = 0;
        Debug.Log(score);
    }
}
