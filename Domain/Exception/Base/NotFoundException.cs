﻿namespace Domain.Exception.Base
{
    public abstract class NotFoundException : System.Exception
    {
        protected NotFoundException(string message)
            : base(message)
        {
        }
    }
}
