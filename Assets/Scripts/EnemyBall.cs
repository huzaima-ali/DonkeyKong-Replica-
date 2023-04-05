using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBall : MonoBehaviour
{
    private GameManager gameManager;
    public int HitCounts;
    private Rigidbody2D EnemyRb;
    private float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        gameManager.GameOver();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hitcounts();
            Destroy(other.gameObject);
            Time.timeScale = 0;
            Debug.Log("GameOver");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    void hitcounts()
    {
        if (HitCounts < 1)
        {
            Debug.Log("Life");
    
        }
    }
}
