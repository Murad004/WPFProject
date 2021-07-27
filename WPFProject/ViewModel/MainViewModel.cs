using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class MainViewModel:BaseViewModel
    {

        public MainWindow MainWindow { get; set; }
        public RelayCommand AdminBtn { get; set; }


        public AdminUserControl AdminUC = new AdminUserControl();

        public MainViewModel()
        {
            AdminBtn = new RelayCommand((e) =>
              {
                  MainWindow.SecondGrid.Children.Add(AdminUC);
              });
            

        }

    }
}
