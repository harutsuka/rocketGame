using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

//ロケットの動きを制御するスクリプト
public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;
    float xLimit = 2.15f;
    public int hp = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    private Vector3 direction;

    public GameObject ResultUI;
    public Text ScoreText;

    public GameManager gameManager;

    public GameObject rocket;

    public SEPlayController SEPlayController;

    float load_width = 6f;
    Vector3 previousPos, currentPos;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.2f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.2f, 0, 0);
        }
        transform.Translate(direction.x * 0.2f, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, new Vector3(transform.position.x,transform.position.y + 0.7f,transform.position.z), Quaternion.identity);
            SEPlayController.BeamSE();
        }

        //動ける範囲の固定
        Vector3 currentPos = transform.position;
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
        transform.position = currentPos;

        //スワイプで動く
        if (Input.GetMouseButtonDown(0))
        {
            previousPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            currentPos = Input.mousePosition;
            float diffDistance = (currentPos.x - previousPos.x) / Screen.width * load_width;

            float newX = Mathf.Clamp(transform.localPosition.x + diffDistance, -xLimit, xLimit);
            transform.localPosition = new Vector3(newX, -3.75f, 0);

            previousPos = currentPos;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("rock"))
        {
            hp--;
            Destroy(collision.gameObject);

            if(hp == 2)
            {
                heart3.SetActive(false);
            }
            if(hp == 1)
            {
                heart2.SetActive(false);
            }
            if (hp <= 0)
            {
                heart1.SetActive(false);
                gameManager.GameEnd();
            }
        }
    }

    public void Tap()
    {
        Instantiate(bulletPrefab, new Vector3(rocket.transform.position.x, rocket.transform.position.y + 0.7f, rocket.transform.position.z), Quaternion.identity);
        SEPlayController.BeamSE();
    }
}
