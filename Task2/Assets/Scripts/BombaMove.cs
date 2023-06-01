using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaMove : MonoBehaviour
{
    Rigidbody _rigidBody;
    bool _isMoving = true;
    float _speed = 1;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();

    }

    void Update()
    {

        transform.position += new Vector3(0, 5f * Time.deltaTime * _speed, 5f * Time.deltaTime * _speed);
        _isMoving = true;


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            _rigidBody.mass = 220;
            _isMoving = false;
            _speed = 0;
        }
    }
}
