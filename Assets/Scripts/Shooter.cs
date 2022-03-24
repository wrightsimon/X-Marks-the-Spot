using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;
    public Camera _camera;
    Rigidbody2D _rigidbody;

    Vector2 mousePosition;

    public float projectileThrust = 20.0f;

    void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        GameObject bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);
        Rigidbody2D _rigidbody = bullet.GetComponent<Rigidbody2D>();
        _rigidbody.AddForce(firePoint.up * projectileThrust, ForceMode2D.Impulse);
    }
}
