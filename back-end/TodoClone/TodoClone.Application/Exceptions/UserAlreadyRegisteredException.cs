using System;

namespace TodoClone.Application.Exceptions
{
    public class UserAlreadyRegisteredException : Exception
    {
        public UserAlreadyRegisteredException(string message) : base(message)
        {
        }
    }
}
