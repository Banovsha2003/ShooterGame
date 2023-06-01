using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, 8f * Time.deltaTime));
    }
}
