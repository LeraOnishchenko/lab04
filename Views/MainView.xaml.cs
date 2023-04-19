using System.Windows.Controls;
using KMA.ProgrammingInCSharp2023.Lab01.DateApp.Tools.Navigation;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl,INavigatable
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
