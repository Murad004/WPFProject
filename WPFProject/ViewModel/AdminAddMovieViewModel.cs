using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;

namespace WPFProject.ViewModel
{
    public class AdminAddMovieViewModel
    {
        public RelayCommand BackBtn { get; set; }

        public AdminAddMovieViewModel()
        {
            BackBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Add(Helper.Helper.AdminFilmMenuUC);
              });
        }
    }
}
