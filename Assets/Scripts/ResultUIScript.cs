using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultUIScript : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject TitleUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RetryButton()
    {
        gameManager.GameStart();
        
    }
    public void HomeButton()
    {
        TitleUI.SetActive(true);
    }
}
