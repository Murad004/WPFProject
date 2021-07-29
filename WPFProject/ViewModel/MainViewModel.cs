﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        public MainWindow MainWindow { get; set; }
        public RelayCommand AdminBtn { get; set; }


        public AdminUserControl AdminUC { get; set; }

        public AdminRegistrationUC AdminRegistrationUC { get; set; }

        public RelayCommand AdminRegistrationBtn { get; set; }

        public MainViewModel()
        {
            AdminBtn = new RelayCommand((e) =>
              {
                  AdminUC = new AdminUserControl();
                  MainWindow.SecondGrid.Children.Add(AdminUC);
              });
            AdminRegistrationBtn = new RelayCommand((e) =>
            {
                AdminRegistrationUC = new AdminRegistrationUC();
                MainWindow.SecondGrid.Children.Add(AdminRegistrationUC);
            });


        }

    }
}
