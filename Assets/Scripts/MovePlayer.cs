using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private const string AxisX = "Horizontal";

    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;

    private bool _isRight = true;

    public float MoveX { get; private set; }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Walk();
    }

    private void Walk()
    {
        MoveX = Input.GetAxis(AxisX);
        Vector2 move = new Vector2(MoveX * _speed, _rigidbody.velocity.y);
        _rigidbody.velocity = move;

        if(MoveX > 0 && _isRight == false)
        {
            Flip();
        }
        else if(MoveX < 0 && _isRight == true)
        {
            Flip();
        }
    }

    private void Flip()
    {
        _isRight = !_isRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1f;
        transform.localScale = scale;
    }
}
