using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private KeyCode _keyJump = KeyCode.Space;

    private bool _isGround;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        Vector2 jump = new Vector2(0, _jumpForce);

        if (Input.GetKeyDown(_keyJump) && _isGround == true)
        {
            _rigidbody.AddForce(jump, ForceMode2D.Force);
            _isGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGround = false;
        }
    }
}
