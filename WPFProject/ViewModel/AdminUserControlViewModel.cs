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
        public MainWindow MainWindow { get; set; }
        public MainViewModel MainViewModel = new MainViewModel();
        public FakeRepoAdmin RepoAdmin { get; set; }

        public AdminUserControl ucadmin { get; set; }
        public RelayCommand SignInBtn { get; set; }
        public RelayCommand RegistrationBtn { get; set; }

        public AdminUserControlViewModel()
        {
            SignInBtn = new RelayCommand((e) =>
              {
                  MessageBox.Show("ncdhbdshjsdjbsdc");
              });
           
            
        }
    }
}
