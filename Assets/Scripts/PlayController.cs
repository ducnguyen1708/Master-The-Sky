using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public GameObject bulletPrefab;
    public Transform _Shoot;
    public float _speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverPlayer();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void MoverPlayer()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x * _speed, y * _speed);
    }
    public void Shoot()
    {
        Instantiate(bulletPrefab, _Shoot.position, transform.rotation);
    }
}
