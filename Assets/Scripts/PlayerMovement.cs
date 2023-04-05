using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D PlayerRb;
    public float jumpForce = 5;
    public bool isOnGround = true;
    public GameObject Weapon;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isOnGround)
        {
            PlayerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        //PlayerRb.AddForce(transform.right * speed * HorizontalMovement);                                 /* linne no. 28+29 both methods runs perfectly */
        PlayerRb.velocity = new Vector2(HorizontalMovement * speed, PlayerRb.velocity.y);
        //PlayerRb.AddForce(transform.up * speed * VerticalMovement);
        if (HorizontalMovement > 0)
        {
            transform.localScale = new Vector3(8, 8, 8);
        }
        if (HorizontalMovement < 0)
        {
            transform.localScale = new Vector3(-8, 8, 8);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder") && Input.GetKey(KeyCode.Backspace))
        {
            transform.position = new Vector3(-26.3f, -14.1f, 17.32f);
            Debug.Log("ladder");
        }
        if (collision.gameObject.CompareTag("Ladder1") && Input.GetKey(KeyCode.Backspace))
        {
            transform.position = new Vector3(12.5f, -6f, 17.32f);
            Debug.Log("ladder");
        }
        if (collision.gameObject.CompareTag("LadderTag") && Input.GetKey(KeyCode.Backspace))
        {
            transform.position = new Vector3(-25.1f, 7.4f, 17.32f);
            Debug.Log("ladder");
        }
        if (collision.gameObject.CompareTag("Ladder2") && Input.GetKey(KeyCode.Backspace))
        {
            transform.position = new Vector3(23.3f, 17.8f, 17.32f);
            Debug.Log("ladder");
        }
        if (collision.gameObject.CompareTag("Ladder3") && Input.GetKey(KeyCode.Backspace))
        {
            transform.position = new Vector3(4.9f, 22.7f, 17.32f);
            Debug.Log("ladder");
        }
    }

    private void OnMouseDown()
    {
        Instantiate(Weapon, transform.position, Weapon.transform.rotation);
    }
}
