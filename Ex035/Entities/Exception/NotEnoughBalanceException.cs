using System;

namespace Ex035.Entities.Exception
{
    class NotEnoughBalanceException : ApplicationException
    {
        public NotEnoughBalanceException(string message) : base(message)
        {
        }
    }
}
