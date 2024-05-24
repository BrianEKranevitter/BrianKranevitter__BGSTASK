using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //This script is C part of MVC pattern

    PlayerModel _model; //M part of MVC pattern
    PlayerView _view; //V part of MVC pattern

    private void Awake()
    {
        _model = GetComponent<PlayerModel>();
        _view = GetComponent<PlayerView>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        var xSpeed = Input.GetAxis("Horizontal");
        var ySpeed = Input.GetAxis("Vertical");

        transform.position += new Vector3( xSpeed* _model.playerSpeed, ySpeed * _model.playerSpeed, 0) * Time.deltaTime;

        if (xSpeed > 0)
            _view.FlipPlayerView(1);
        else if(xSpeed<0)
            _view.FlipPlayerView(-1);
    }
}