using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Command;
using WPFProject.View;

namespace WPFProject.ViewModel
{
    public class AdminFilmMenuViewModel
    {

        public RelayCommand AddMovieListBtn { get; set; }
        public RelayCommand RemoveMovieListBtn { get; set; }



        public AdminFilmMenuViewModel()
        {
            AddMovieListBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Add(Helper.Helper.AdminAddMovieUC);
              });

            RemoveMovieListBtn = new RelayCommand((e) =>
              {
                  Helper.Helper.MainWindow.SecondGrid.Children.Add(Helper.Helper.AdminRemoveMovieUC);
              });
        }
    }
}
