using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    Player player;
    [SerializeField] GameObject BulletObject;
    [SerializeField] GameObject SpawnBullet;
    public LayerMask layer;
    RaycastHit hit;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        Fire();
    }
    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(player.transform.position, player.transform.forward, out hit, 100f, layer))
        {
            SpawnBullet = Instantiate(BulletObject, player.transform.position, player.transform.rotation);
            SpawnBullet.AddComponent<BulletMove>();
            SpawnBullet.AddComponent<DestroyBullet>();
            SpawnBullet.gameObject.tag = "playerBullet";
        }
    }
}
