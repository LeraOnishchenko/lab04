﻿using System.Windows.Controls;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Tools.Navigation
{
    interface IContentOwner
    {
        ContentControl ContentControl { get; }
    }
}
