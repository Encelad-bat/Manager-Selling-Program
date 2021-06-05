using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Manager_Selling_Program.Model;

namespace Manager_Selling_Program.ViewModel
{
    class Car_ViewModel : INotifyPropertyChanged
    {

        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

        Car_ViewModel instance = null;

        public Car_ViewModel Instance { get {
                if (this.instance == null)
                {
                    this.instance = new Car_ViewModel();
                }
                return this.instance;
            } }


        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

        Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; OnPropertyChanged("SelectedCar"); }
        }

        private static ObservableCollection<Car> cars = new ObservableCollection<Car>(Model.Model.Read_Objects<Car>());

        public static ObservableCollection<Car> Cars
        {
            get { return cars; }
            set { cars = value; new Car_ViewModel().OnPropertyChanged("Cars"); }
        }

        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
