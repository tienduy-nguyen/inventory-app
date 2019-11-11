using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WareHouseManagement.ViewModel
{
    public class ControlBarViewmModel: BaseViewModel
    {
        #region commands
        public  ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MouseMoveWindowCommand { get; set; }
        #endregion

        public ControlBarViewmModel()
        {
            CloseWindowCommand = new RelayCommand<UserControl>(
                (p) => !(p is null),
                (p) =>
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    w?.Close();
                });

            MaximizeWindowCommand = new RelayCommand<UserControl>(
                (p) => !(p is null),
                (p) =>
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.WindowState = w.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;
                    }
                });
            MinimizeWindowCommand = new RelayCommand<UserControl>(
                (p) => !(p is null),
                (p) =>
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                        w.WindowState = w.WindowState != WindowState.Minimized ? WindowState.Minimized : WindowState.Normal;
                    }
                });

            MouseMoveWindowCommand = new RelayCommand<UserControl>(
                (p) => !(p is null),
                (p) =>
                {
                    FrameworkElement window = GetWindowParent(p);
                    var w = window as Window;
                    if (w != null)
                    {
                       w.DragMove();
                    }
                });
        }

        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;
            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
    }
}
