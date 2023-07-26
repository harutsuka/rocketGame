using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//ロケットの動きを制御するスクリプト
public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;
    float xLimit = 2.15f;
    public int hp = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public Text gameOverText;

    private Vector3 direction;
    public FixedJoystick Joystick;
    //public FloatingJoystick Joystick;

    public GameObject ResultUI;
    public Text ScoreText;

    public GameManager gameManager;

    public GameObject rocket;

    public AudioClip SE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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
            audioSource.PlayOneShot(SE);
        }

        //動ける範囲の固定
        Vector3 currentPos = transform.position;
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
        transform.position = currentPos;
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
        audioSource.PlayOneShot(SE);
    }

    private void FixedUpdate()
    {
        //Joystickの動き
        direction = Vector3.forward * Joystick.Vertical + Vector3.right * Joystick.Horizontal;
    }
    
}
