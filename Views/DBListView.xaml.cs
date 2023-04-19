using System.Windows.Controls;
using KMA.ProgrammingInCSharp2023.Lab01.DateApp.Tools.Navigation;
using KMA.ProgrammingInCSharp2023.Lab01.DateApp.ViewModels;

namespace KMA.ProgrammingInCSharp2023.Lab01.DateApp.Views
{
    /// <summary>
    /// Interaction logic for DBListView.xaml
    /// </summary>
    public partial class DBListView : UserControl,INavigatable
    {
        public DBListView()
        {
            InitializeComponent();
            DataContext = new DBListViewModel(delegate { Dispatcher.Invoke(PersonsDataGrid.Items.Refresh); });
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
