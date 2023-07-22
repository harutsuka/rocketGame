using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject TitleUI;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ReadyToStart()
    {
        TitleUI.SetActive(false);
        gameManager.GameStart();
    }
    
}
