using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] float _speed;

    private bool _isRight;

    private void Update()
    {
        SetDirection();
        MoveEnemy();
    }

    private void SetDirection()
    {
        if (_isRight == true && transform.position == _points[1].position)
        {
            Flip();
        }
        else if(_isRight == false && transform.position == _points[0].position)
        {
            Flip();
        }
    }

    private void MoveEnemy()
    {
        if(_isRight == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _points[1].position, _speed * Time.deltaTime);
        }
        else if (_isRight == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _points[0].position, _speed * Time.deltaTime);
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
