using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] GameObject SpawnBullet;
    

    void Start()
    {
        StartCoroutine(Fire());
    }

    void Update()
    {
        
    }
    IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            SpawnBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            SpawnBullet.AddComponent<EnemyBulletMove>();
            SpawnBullet.gameObject.tag = "enemyBullet";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "playerBullet")
        {
           
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
