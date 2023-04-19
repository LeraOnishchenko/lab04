using System;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Exceptions
{
    internal class EmailException : Exception
    {
        public EmailException(string message) : base(message)
        {
        }
    }
}
