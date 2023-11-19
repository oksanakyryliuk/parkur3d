using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5.0f;
    public float JumpForce = 8.0f;
    public float Gravity = 30.0f;

    private Vector3 _moveDirection = Vector3.zero;
    private CharacterController _controller;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        if (_controller.isGrounded)
        {
            var input = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
            _moveDirection = input * Speed;

            if (Input.GetButtonDown("Jump"))
            {
                _moveDirection.y = JumpForce;
            }
        }

        _moveDirection.y -= Gravity * Time.deltaTime;
        _controller.Move(_moveDirection * Time.deltaTime);
    }
}