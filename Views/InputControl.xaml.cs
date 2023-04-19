using System.Windows.Controls;
using KMA.ProgrammingInCSharp2023.Lab01.DateApp.ViewModels.InputDate;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Views
{
    /// <summary>
    /// Interaction logic for InputView.xaml
    /// </summary>
    public partial class InputControl:UserControl
    {
        public InputControl()
        {
            InitializeComponent();
            DataContext = new InputDateViewModel();
        }
    }
}
