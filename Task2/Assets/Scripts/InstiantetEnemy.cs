using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstiantetEnemy : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    GameObject Go;
    Player player;
    
    void Start()
    {
        StartCoroutine(InitialiserEnemy());
        player = FindObjectOfType<Player>();
    }

    void Update()
    {

    }
    IEnumerator InitialiserEnemy()
    {
        player = FindObjectOfType<Player>();
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Go = Instantiate(Enemy, new Vector3(Random.Range(0, 6), 1, Random.Range(0, 6)), player.transform.rotation);
            Go.AddComponent<EnemyMove>();
            Go.layer = 6;
            
        }
    }
}
