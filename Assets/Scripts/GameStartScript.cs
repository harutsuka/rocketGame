using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject TitleUI;

    public GameManager gameManager;

    bool isPlaying = GameManager.isPlaying;
    // Start is called before the first frame update
    void Start()
    {
        TitleUI.SetActive(true);

        //startが呼び出されてるかの確認　呼び出されている
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public void ReadyToStart()
    {
        TitleUI.SetActive(false);
        gameManager.GameStart();
        isPlaying = true;
        Debug.Log(isPlaying);
    }
    
}
