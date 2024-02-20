using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingItems : MonoBehaviour
{
    [SerializeField] private KeyCode _keyLoot = KeyCode.E;
    [SerializeField] private bool _isApple;
    [SerializeField] private GameObject _lootObject;

    private void Update()
    {
        Looting();
    }

    private void Looting()
    {
        if(_isApple == true && Input.GetKeyDown(_keyLoot) && _lootObject != null)
        {
            Destroy(_lootObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Apple")
        {
            _isApple = true;
            _lootObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            _isApple = false;
            _lootObject = null;
        }
    }
}
