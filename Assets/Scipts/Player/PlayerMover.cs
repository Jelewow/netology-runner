using System.Collections;
using Netology.Runner.Input;
using UnityEngine;

namespace Netology.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMover : MonoBehaviour
    {
        private const float GravityValue = -9.81f;
        
        [SerializeField] private InputType _inputType;
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _jumpPower;

        private IInputService _input;
        private CharacterController _characterController;
        
        private Vector3 _direction;
        private float _velocity;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            
            if (_inputType == InputType.Old)
            {
                _input = new OldInputSystem();
            }
            else
            {
                _input = new NewInputService();
            }
        }

        private void OnEnable()
        {
            _input.SpacePressed += OnSpacePressed;
        }

        private void OnDisable()
        {
            _input.SpacePressed -= OnSpacePressed;
        }

        private void Update()
        {
            _input.Update();

            _direction = new Vector3(_input.HorizontalInput, _velocity, 0f) + transform.forward;

            _characterController.Move(_direction * (_moveSpeed * Time.deltaTime));
        }

        public void BoostSpeed(float additionalSpeed, float boostTime)
        {
            StartCoroutine(BoostingSpeed(additionalSpeed, boostTime));
        }

        private IEnumerator BoostingSpeed(float additionalSpeed, float boostTime)
        {
            _moveSpeed += additionalSpeed;
            
            yield return new WaitForSeconds(boostTime);

            _moveSpeed -= additionalSpeed;
        }
        
        private void OnSpacePressed()
        {
            if (_characterController.isGrounded)
            {
                _velocity = 0f;
            }
            else
            {
                _velocity += GravityValue * Time.deltaTime;
            }

            _direction.y = _velocity * _jumpPower;
        }
    }
}