using System;

namespace Ex035.Entities.Exception
{
    class AmountExceedsException : ApplicationException
    {
        public AmountExceedsException(string message) : base(message)
        { 
        }
    }
}
