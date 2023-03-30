using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySw : MonoBehaviour
{
    [SerializeField] GameObject enemyprefab;
    public Transform _target;
    private float  _timer;
    [SerializeField] private float rate = 2;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer < 0)
        {
            EnemSpawnS();
            _timer = rate;
        }
    }
    private void LateUpdate() {
        Vector2 move = transform.position;
        move.x += speed * Time.deltaTime;
        if(move.x > 5)
        {
            speed = -3;
        }
        if(move.x < -5)
        {
            speed = 3;
        }
        transform.position = move;
    }
    int GetSgin()
    {
        if(Random.Range(0,10) > 5)return 1;
        return -1;
    }
    public void EnemSpawnS()
    {
        Vector2 pos = _target.position;
        pos.x = Random.Range(5,10) * GetSgin();
        pos.y = 6;
        GameObject enemyObject = Instantiate(enemyprefab, pos,Quaternion.identity);
        Enemy enemy =enemyObject.GetComponent<Enemy>();
        enemy.target = _target;
    }
}
