using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float timer = 3;
    void Update()
    {
        CheckEnemyShoot();
    }
    private void CheckEnemyShoot()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            GameManager.Instance.GameOver();
        }
    }
}
