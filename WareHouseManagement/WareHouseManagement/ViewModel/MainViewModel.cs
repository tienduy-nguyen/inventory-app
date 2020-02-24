using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WareHouseManagement;
using WareHouseManagement.Models;

namespace WarehouseManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand LoadedWindowCommand { get; set; }
        public RelayCommand UnitWindowCommand { get; set; }
        public RelayCommand SuplierWindowCommand { get; set; }
        public RelayCommand CustomerWindowCommand { get; set; }
        public RelayCommand ObjectWindowCommand { get; set; }
        public RelayCommand UserWindowCommand { get; set; }
        public RelayCommand InputWindowCommand { get; set; }
        public RelayCommand OutputWindowCommand { get; set; }
        public bool IsLoaded = false;


        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand(param => this.LoadWindowExecuted(param));
            UnitWindowCommand = new RelayCommand(param => this.UnitWindowExecuted(param));
            SuplierWindowCommand = new RelayCommand(param => this.SupplierWindowExecuted(param));
            CustomerWindowCommand = new RelayCommand(param => this.CustomerWindowExecuted(param));
            ObjectWindowCommand = new RelayCommand(param => this.MaterialWindowExecuted(param));
            UserWindowCommand = new RelayCommand(param => this.UserWindowExecuted(param));
            InputWindowCommand = new RelayCommand(param => this.InputWindowExecuted(param));
            OutputWindowCommand = new RelayCommand(param => this.OutputWindowExecuted(param));

            var a = DataProvider.Instance.DB.Users;

        }

        


        #region RelayCommand
        private void LoadWindowExecuted(object param)
        {
            IsLoaded = true;
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }
        private void UnitWindowExecuted(object param)
        {
            UnitWindow uw = new UnitWindow(); ;
            uw.ShowDialog();
        }
        private void SupplierWindowExecuted(object param)
        {
            SuplierWindow sw = new SuplierWindow();
            sw.ShowDialog();
        }
        private void CustomerWindowExecuted(object param)
        {
            CustomerWindow cw = new CustomerWindow();
            cw.ShowDialog();
        }
        private void MaterialWindowExecuted(object param)
        {
            ObjectWindow ow = new ObjectWindow();
            ow.ShowDialog();
        }
        private void UserWindowExecuted(object param)
        {
            UserWindow uw = new UserWindow();
            uw.ShowDialog();
        }
        private void InputWindowExecuted(object param)
        {
            InputWindow iw = new InputWindow();
            iw.ShowDialog();
        }
        private void OutputWindowExecuted(object param)
        {
            OutputWindow iw = new OutputWindow();
            iw.ShowDialog();
        }

        #endregion
    }
}
