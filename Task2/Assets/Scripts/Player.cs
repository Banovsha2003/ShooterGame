using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed = 4;
    public float health = 100;
    float xPos;
    float yPos;

    void Start()
    {

    }

    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        MovePlayer();
    }
    private void MovePlayer()
    {
        

        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        xPos = Mathf.Clamp(transform.position.x, -80f, 80f);
        float zPos = Mathf.Clamp(transform.position.z, -150f, 150f);
        transform.position = new Vector3(xPos, transform.position.y, zPos);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0, -90 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0, 90 * Time.deltaTime, 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (health < 0)
        {
            Destroy(gameObject);
            return;
        }
        if (collision.gameObject.tag == "enemyBullet")
        {
            health -= 10;
            Destroy(collision.gameObject);
        }

    }
}
