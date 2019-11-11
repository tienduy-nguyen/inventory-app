using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WarehouseManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand LoadedWindowCommand { get; set; }
        public bool IsLoaded = false;
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    IsLoaded = true;
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.ShowDialog();
                });
        }
    }
}
