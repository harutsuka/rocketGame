using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockController : MonoBehaviour
{
    int rockHP;
    int score;
    public GameObject explosionPrefab;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rockHP = Random.Range(1, 6);
        rotationSpeed = Random.Range(-500, -50);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bullet")
        {
            GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 1.0f);
            Destroy(collision.gameObject);
            rockHP--;
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            
            //Debug.Log(rockHP);
            if (rockHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
