using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;

    private Rigidbody enemyRB;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(playerPosition * speed);
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }

    }
}
