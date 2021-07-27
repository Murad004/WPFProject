using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFProject.Command;
using WPFProject.Repository;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminUserControlViewModel:BaseViewModel
    {
        public MainWindow MainWindow = new MainWindow();
        public FakeRepoAdmin RepoAdmin { get; set; }
        public AdminUserControl ucadmin { get; set; }

        public AdminRegistrationUC AdminRegistrationUC = new AdminRegistrationUC();

        public RelayCommand SignInBtn { get; set; }
        public RelayCommand RegistrationBtn { get; set; }
        public RelayCommand ExitBtnReg { get; set; }

        public AdminUserControlViewModel()
        {
            SignInBtn = new RelayCommand((e) =>
              {
                  foreach (var admin in RepoAdmin.Admins)
                  {
                      if (ucadmin.UsernameTxtBoxAdmin.Text == admin.Email && ucadmin.PasswordBoxAdmin.Password == admin.Password)
                      {
                          MessageBox.Show("Sucsesfully!");
                      }
                  }
              });
            RegistrationBtn = new RelayCommand((e) =>
              {
                  MainWindow.SecondGrid.Children.Add(AdminRegistrationUC);
              });
            
        }
    }
}
