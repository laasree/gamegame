using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    [SerializeField]private GameObject _gameOverWindow;

    private void Awake()
    {
        _gameOverWindow.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        collision.gameObject.SetActive(false);
        _gameOverWindow.SetActive(true);
    }
}
