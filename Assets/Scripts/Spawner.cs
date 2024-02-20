using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _itemAple;

    private void Start()
    {
        Spawning();
    }

    private void Spawning()
    {
        Instantiate(_itemAple, transform);
    }
}
