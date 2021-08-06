using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFProject.Command;
using WPFProject.Models;
using WPFProject.Repository;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminUserControlViewModel : BaseViewModel
    {
        public MainWindow MainWindow = new MainWindow();

        public MainViewModel MainViewModel = new MainViewModel();

        public FakeRepoAdmin RepoAdmin = new FakeRepoAdmin();

        public AdminUserControl ucadmin { get; set; }
        public RelayCommand SignInBtn { get; set; }

        public RelayCommand SignUpBtn { get; set; }

        public AdminFilmMenuUC AdminFilmMenuUC = new AdminFilmMenuUC();


        public AdminUserControlViewModel()
        {
            SignUpBtn = new RelayCommand((e) =>
              {
                  
                  RepoAdmin.Admins.Add(new Admin(
                      ucadmin.textBoxFirstName.Text,
                      ucadmin.textBoxLastName.Text,
                      int.Parse(ucadmin.textBoxAge.Text),
                      ucadmin.DatePicker.Text,
                      ucadmin.textBoxEmail.Text,
                      ucadmin.PasswordBox.Password
                      ));
                  ucadmin.textBoxFirstName.Text = String.Empty;
                  ucadmin.textBoxLastName.Text = String.Empty;
                  ucadmin.textBoxAge.Text = String.Empty;
                  ucadmin.textBoxEmail.Text = String.Empty;
                  ucadmin.DatePicker.Text = String.Empty;
                  ucadmin.PasswordBox.Password = String.Empty;
                  MainWindow.SecondGrid.Children.Remove(ucadmin);
                  MainWindow.SecondGrid.Children.Add(AdminFilmMenuUC);
                  
              });
            SignInBtn = new RelayCommand((e) =>
              {
                  foreach (var admin in RepoAdmin.Admins)
                  {
                      if (ucadmin.UsernameTxtBoxAdmin.Text == admin.Email && ucadmin.PasswordBoxAdmin.Password == admin.Password)
                      {
                          MessageBox.Show("ischbcsujbjns");
                      }
                      else
                      {
                          MessageBox.Show("bbb");
                      }
                  }
              });


        }
    }
}
