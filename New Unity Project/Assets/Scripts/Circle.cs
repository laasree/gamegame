using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle : MonoBehaviour
{
    [HideInInspector]public bool _isDirectionLeft;

    [SerializeField] private float _rollingForce = 1;

    private GameObject _platform;
    private GameObject _arrowRight;
    private GameObject _arrowLeft;


    private void Awake()
    {
        _platform = GameObject.FindGameObjectWithTag("Platform");
        _arrowLeft = GameObject.FindGameObjectWithTag("ArrowLeft");
        _arrowRight = GameObject.FindGameObjectWithTag("ArrowRight");
    }

    private void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
    }


    private void FixedUpdate()
    {
        _platform.GetComponent<SurfaceEffector2D>().speed = _rollingForce;

        directionDefenition();
    }

    private void directionDefenition()
    {
        if (_rollingForce > 0)
        {
            _isDirectionLeft = false;
        }
        else if (_rollingForce < 0)
        {
            _isDirectionLeft = true;
        }


        if (_isDirectionLeft == true)
        {
            _arrowRight.SetActive(false);
            _arrowLeft.SetActive(true);

        }
        else if (_isDirectionLeft == false)
        {
            _arrowLeft.SetActive(false);
            _arrowRight.SetActive(true);
        }
    }

    public void  OnClickChangeDirection()
    {
        if(_rollingForce < 0)
        {
            _rollingForce -= 0.1f;
        }
        else if(_rollingForce > 0)
        {
            _rollingForce += 0.1f;
        }
        else
        {
            Debug.Log("OnClickChangeDirection error has occurred");
        }

        _rollingForce *= -1;
    }

}
