using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody enemyBody;
    private GameObject player;

    private void Start()
    {
        enemyBody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyBody.AddForce(lookDirection * speed);
    }
}
