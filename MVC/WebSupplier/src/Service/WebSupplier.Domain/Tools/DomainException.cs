using System;
using System.Collections.Generic;
using System.Text;

namespace WebSupplier.Domain.Tools
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
