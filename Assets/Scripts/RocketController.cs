using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;
    float xLimit = 2.25f;
    public int hp = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public Text gameOverText;

    private Vector3 direction;
    public FixedJoystick Joystick;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
        }

        //動ける範囲の固定
        Vector3 currentPos = transform.position;
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
        transform.position = currentPos;

        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("hit");
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
                GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            }
        }
    }

    private void FixedUpdate()
    {
        //Joystickの動き
        direction = Vector3.forward * Joystick.Vertical + Vector3.right * Joystick.Horizontal;
    }
}
