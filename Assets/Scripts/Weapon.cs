using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float Speed = 50;
    private GameManager gameManager;
    public int ScoreToIncrease;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManger").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            gameManager.UpdateScore(ScoreToIncrease);
            Debug.Log("ScoreIncreased");
        }
    }
    
}
