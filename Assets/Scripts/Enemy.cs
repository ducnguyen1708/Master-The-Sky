using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab;
    public Transform target;
    public Rigidbody2D rb;
    private float speed = 0.5f;
    public GameObject enemyPrefabShoot;
    private float rate = 3;
    private float timerShoot;
    void Update()
    {
        rb.velocity = (target.position - transform.position) * speed;
    }
    private void FixedUpdate() {
        timerShoot -= Time.deltaTime;
        if(timerShoot < 0){
            EnemyShoot();
            timerShoot = rate;
        }
    }
    public void Dead()
    {
        Destroy(gameObject);
        Instantiate(explosionPrefab, transform.position,Quaternion.identity);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            GameManager.Instance.GameOver();
        }
    }
    private void EnemyShoot()
    {
        Instantiate(enemyPrefabShoot, transform.position,Quaternion.identity);
    }
}
