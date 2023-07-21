using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject walls;
    private float timer = 0;
    private int interval = 3;

    bool isPlaying = GameManager.isPlaying;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying == true)
        {
            timer += Time.deltaTime;
            if (timer >= interval)
            {
                Instantiate(walls, new Vector3(0f, 7.0f, 0.0f), Quaternion.identity);
                timer = 0;
            }
            if (transform.position.y < -5.5f)
            {
                Destroy(gameObject);
            }
        }
    }
}
