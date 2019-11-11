using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WareHouseManagement;

namespace WarehouseManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitWindowCommand { get; set; }
        public ICommand SuplierWindowCommand { get; set; }
        public ICommand CustomerWindowCommand { get; set; }
        public ICommand ObjectWindowCommand { get; set; }
        public ICommand UserWindowCommand { get; set; }
        public ICommand InputWindowCommand { get; set; }
        public ICommand OutputWindowCommand { get; set; }
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

            UnitWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    UnitWindow uw = new UnitWindow();;
                    uw.ShowDialog();
                });

            SuplierWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    SuplierWindow sw = new SuplierWindow() ;
                    sw.ShowDialog();
                });

            CustomerWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    CustomerWindow  cw = new CustomerWindow();
                    cw.ShowDialog();
                });

            ObjectWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    ObjectWindow ow = new ObjectWindow();
                    ow.ShowDialog();
                });
            UserWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    UserWindow uw = new UserWindow();
                    uw.ShowDialog();
                });
            InputWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    InputWindow iw = new InputWindow();
                    iw.ShowDialog();
                });
            OutputWindowCommand = new RelayCommand<object>(
                (p) => true,
                (p) =>
                {
                    OutputWindow iw = new OutputWindow();
                    iw.ShowDialog();
                });
        }
    }
}
