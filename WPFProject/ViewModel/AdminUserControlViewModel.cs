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
    public class AdminUserControlViewModel : BaseViewModel
    {
        public MainWindow MainWindow { get; set; }

        public MainViewModel MainViewModel = new MainViewModel();

        public FakeRepoAdmin RepoAdmin { get; set; }

        public AdminUserControl ucadmin { get; set; }
        public RelayCommand SignInBtn { get; set; }


        public AdminUserControlViewModel()
        {
            SignInBtn = new RelayCommand((e) =>
              {
                  RepoAdmin = new FakeRepoAdmin();
                  ucadmin = new AdminUserControl();
                  foreach (var admin in RepoAdmin.GetAdmins())
                  {
                      if (ucadmin.UsernameTxtBoxAdmin.Text != String.Empty || ucadmin.PasswordBoxAdmin.Password != String.Empty)
                      {

                          if (ucadmin.UsernameTxtBoxAdmin.Text == admin.Email && ucadmin.PasswordBoxAdmin.Password == admin.Password)
                          {
                              MessageBox.Show("Sucsesfully!");
                          }
                          else
                          {
                              MessageBox.Show("Not Sucsesfully!");
                          }
                      }
                      else
                      {
                          MessageBox.Show("ksfcnhdscbhcj scjbnsc hjnmsd jkd");
                      }
                  }
              });


        }
    }
}
