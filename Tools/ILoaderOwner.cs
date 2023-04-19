using System.ComponentModel;
using System.Windows;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
