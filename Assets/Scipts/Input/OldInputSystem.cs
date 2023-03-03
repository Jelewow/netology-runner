using System;
using UnityEngine;

namespace Netology.Runner.Input
{
    public class OldInputSystem : IInputService
    {
        public float HorizontalInput { get; private set; }
        
        public event Action SpacePressed;
        
        public void Update()
        {
            HorizontalInput = UnityEngine.Input.GetAxis("Horizontal");

            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                SpacePressed?.Invoke();
            }
        }
    }
}