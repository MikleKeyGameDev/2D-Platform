using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour
{
    private Animator _animator;
    private MovePlayer _movePlayer;

    private void Start()
    {
        _movePlayer = GetComponent<MovePlayer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        SwitchRun();
    }

    private void SwitchRun()
    {
        _animator.SetBool("isRun", _movePlayer.MoveX != 0f);
    }
}
