using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyBullets());
    }

    void Update()
    {

    }
    IEnumerator DestroyBullets()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
