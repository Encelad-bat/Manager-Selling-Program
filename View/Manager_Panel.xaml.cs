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
    /// Interaction logic for Manager_Panel.xaml
    /// </summary>
    public partial class Manager_Panel : UserControl
    {
        public Manager_Panel()
        {
            InitializeComponent();
            Model.Model.connection = "Data Source = SQL5097.site4now.net; Initial Catalog = db_a7538c_main; User Id = db_a7538c_main_admin; Password = Gorb_bc24";
            this.DataContext = new Car_ViewModel();
        }

        private void sell_Button_Click(object sender, RoutedEventArgs e)
        {
            if(cars_ListView.Items.Count != 0)
            {
                if(cars_ListView.SelectedItem != null)
                {
                    _Order New_order = new _Order(cars_ListView.SelectedItem as Car, DateTime.Now);

                    #region DateTime Check
                    if (Order_ViewModel.Orders.Count != 0)
                    {
                        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

                        if (New_order.End_date_of_order.Month < Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.Month)
                        {
                            New_order.End_date_of_order = Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.AddDays(1);
                        }

                        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

                        if (New_order.End_date_of_order.Month < Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.Month)
                        {
                            New_order.End_date_of_order = Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.AddDays(1);
                        }

                        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

                        if (New_order.End_date_of_order.Hour < Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.Hour)
                        {
                            New_order.End_date_of_order = Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.AddHours(1);
                        }

                        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

                        if (New_order.End_date_of_order.Minute < Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.Minute)
                        {
                            New_order.End_date_of_order = Order_ViewModel.Orders[Order_ViewModel.Orders.Count - 1].End_date_of_order.AddMinutes(1);
                        }

                        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲
                    }
                    #endregion

                    New_order.End_date_string = New_order.End_date_of_order.ToString("dd.MM.yyyy");
                    Order_ViewModel.Orders.Add(New_order);
                    Model.Model.Create_Object((object)New_order, typeof(_Order));

                    Model.Model.Delete_Objects(cars_ListView.SelectedItem,typeof(Car));
                    Car_ViewModel.Cars.Remove(cars_ListView.SelectedItem as Car);
                }
            }
        }
    }
}
