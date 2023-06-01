using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float Enemyspeed = 1;
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        
        transform.position = Vector3.Lerp(transform.position, player.transform.position, .1f * Time.deltaTime);
        transform.LookAt(player.transform);

    }
}
