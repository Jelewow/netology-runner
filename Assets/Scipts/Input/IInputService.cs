using System;

namespace Netology.Runner.Input
{
    public interface IInputService
    {
        float HorizontalInput { get; }

        event Action SpacePressed;

        void Update();
    }
}
