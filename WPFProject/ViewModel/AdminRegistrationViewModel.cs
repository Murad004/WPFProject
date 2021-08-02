using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;
using WPFProject.Models;
using WPFProject.Repository;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminRegistrationViewModel
    {
        public AdminRegistrationUC adminRegistrationUC { get; set; }

        public RelayCommand SignUpBtn { get; set; }

        public MainWindow MainWindow { get; set; }

        public AdminUserControl AdminUC { get; set; }

        public User User { get; set; }

        public FakeRepoAdmin RepoAdmins { get; set; }

        public AdminRegistrationViewModel()
        {
            SignUpBtn = new RelayCommand((e) =>
              {
                  adminRegistrationUC = new AdminRegistrationUC();
                  RepoAdmins = new FakeRepoAdmin();
                  RepoAdmins.Admins.Add(new Admin(adminRegistrationUC.textBoxFirstName.Text, adminRegistrationUC.textBoxLastName.Text, int.Parse(adminRegistrationUC.textBoxAge.Text), DateTime.Now.ToShortDateString(), adminRegistrationUC.textBoxEmail.Text, adminRegistrationUC.PasswordBox.Password));
                  AdminUC = new AdminUserControl();
                  MainWindow.SecondGrid.Children.Add(AdminUC);
                   
              });
        }
    }
}
