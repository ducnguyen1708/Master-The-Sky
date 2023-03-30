using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;
    public float speedBullet = 5;
    public float _timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckBullet();
    }
    void FixedUpdate() {
        MoverBullet();   
    }
    private void CheckBullet()
    {
        _timer -= Time.deltaTime;
        if(_timer < 0)
        {
            Destroy(gameObject);
        }
    }
    private void MoverBullet()
    {
        rb.velocity = Vector2.up * speedBullet;
    }
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.CompareTag("Enemy"))
        {
            //Destroy(col.gameObject);
            Enemy enemy = col.GetComponent<Enemy>();
            enemy.Dead();
            GameManager.Instance.GainScore();
        }
    }
}
