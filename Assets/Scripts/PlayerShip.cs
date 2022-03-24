using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public float speed = 20.0f;
    public int score = 0;

    Rigidbody2D _rigidbody;

    Vector2 movement;
    Vector2 mousePosition;

    void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move() 
    {
        //Move forward or backward on WS press
        _rigidbody.AddRelativeForce(new Vector2(0, movement.y) * speed * Time.fixedDeltaTime);

        //Rotate on AD press
        _rigidbody.MoveRotation(_rigidbody.rotation + movement.x * -speed * Time.fixedDeltaTime);
        //transform.Rotate(0, 0, movement.x * speed * -1 );
    }

}
