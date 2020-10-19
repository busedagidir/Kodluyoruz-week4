using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController _controller;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce = 5f;
    private bool _groundedPlayer;
    private Vector3 _velocity;
    private float _jumpHeight = 3.0f;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        _groundedPlayer = _controller.isGrounded;
        if(_groundedPlayer && _velocity.y < 0)
        {
            _velocity.y = 0f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        _controller.Move(movement * _speed * Time.deltaTime);

        if(movement != Vector3.zero)
        {
            transform.forward = movement;
        }

        if(Input.GetButtonDown("Jump") && _groundedPlayer)
        {
            _velocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * Physics.gravity.y);
        }

        //gravity
        _velocity.y += Physics.gravity.y * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

    }
   
}
