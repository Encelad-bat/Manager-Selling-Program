using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Manager_Selling_Program.ViewModel;
using Manager_Selling_Program.Model;
using System.Collections.ObjectModel;

namespace Manager_Selling_Program.View
{
    /// <summary>
    /// Interaction logic for Current_Orders.xaml
    /// </summary>
    public partial class Current_Orders : UserControl
    {
        public Current_Orders()
        {
            InitializeComponent();
            this.DataContext = new Order_ViewModel();
            Order_ViewModel.Orders = new ObservableCollection<_Order>(Model.Model.Read_Objects<_Order>());
        }
    }
}
