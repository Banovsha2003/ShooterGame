using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstiantetBomba : MonoBehaviour
{
    [SerializeField] GameObject bomba;
    Player player;
    GameObject Go;
    public Collider[] colliders;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Go = Instantiate(bomba, player.transform.position, player.transform.rotation);
            Go.AddComponent<BombaMove>();
            colliders = Physics.OverlapSphere(transform.position, 12f);
            StartCoroutine(Bomb());
        }
    }
    IEnumerator Bomb()
    {
        yield return new WaitForSeconds(2f);
        foreach (Collider collider in colliders)
        {
            collider.gameObject.AddComponent<Rigidbody>();
            Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.AddExplosionForce(250f, transform.position, 2 * 2f);
        }
    }
}
