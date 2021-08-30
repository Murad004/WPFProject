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
    public class UserUCViewModel : BaseViewModel
    {
        public UserUC UserUC { get; set; }
        public RelayCommand LogInBtn { get; set; }
        public RelayCommand SignUpBtn { get; set; }

        public FakeRepoUsers RepoUsers = new FakeRepoUsers();

        public UserFilmMenuUC UserFilmMenuUC = Helper.Helper.UserFilmMenuUC;

        public MainWindow MainWindow = Helper.Helper.MainWindow;


        public UserUCViewModel()
        {
            SignUpBtn = new RelayCommand((e) =>
              {
                  RepoUsers.Users.Add(new User(
                      UserUC.NameTxtBox.Text,
                      UserUC.SurnameTxtBox.Text,
                      UserUC.DatePicker.Text,
                      UserUC.EmailTxtBox.Text,
                      UserUC.PasswordBox.Password,
                      int.Parse(UserUC.AgeTxtBox.Text)
                      ));
                  UserUC.NameTxtBox.Text = String.Empty;
                  UserUC.SurnameTxtBox.Text = String.Empty;
                  UserUC.DatePicker.Text = String.Empty;
                  UserUC.EmailTxtBox.Text = String.Empty;
                  UserUC.PasswordBox.Password = String.Empty;
                  UserUC.AgeTxtBox.Text = String.Empty;
                  MessageBox.Show("Qeydiyyat ugurludur");
              });
            LogInBtn = new RelayCommand((e) =>
              {
                  foreach (var user in RepoUsers.Users)
                  {
                      if (UserUC.UsernameTxtBoxUser.Text == user.Email && UserUC.PasswordBoxUser.Password == user.Password)
                      {
                          MainWindow.SecondGrid.Children.Add(UserFilmMenuUC);
                      }
                      else
                      {
                          MessageBox.Show("nnn");
                      }
                  }
              });
        }
    }
}
