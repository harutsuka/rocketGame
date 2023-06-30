using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject TitleButtton;
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void FinishGame()
    {
        SceneManager.LoadScene("Title");
        TitleButtton.SetActive(false);
    }

    public void ReadyToStart()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1.0f;
        StartButton.SetActive(false);
    }
}
