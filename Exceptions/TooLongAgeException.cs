﻿using System;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Exceptions
{
    internal class TooLongAgeException: Exception
    {
        public TooLongAgeException(string message) : base(message) { }
    }
}
