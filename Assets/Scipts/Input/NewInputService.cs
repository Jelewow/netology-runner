using System;
using UnityEngine.InputSystem;

namespace Netology.Runner.Input
{
    public class NewInputService : IInputService
    {
        private PlayerNewInput _input;
        
        public float HorizontalInput { get; private set; }
        
        public event Action SpacePressed;

        public NewInputService()
        {
            _input = new PlayerNewInput();
            _input.Enable();

            _input.Move.Jumping.performed += OnSpacePressed;
        }
        
        public void Update()
        {
            HorizontalInput = _input.Move.Moving.ReadValue<float>();
        }
        
        private void OnSpacePressed(InputAction.CallbackContext obj)
        {
            SpacePressed?.Invoke();
        }
    }
}