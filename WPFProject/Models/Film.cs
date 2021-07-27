using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject.Models
{
    public class Film
    {
        public Film(string title, double price, string genre, string date, int runTime)
        {
            Title = title;
            Price = price;
            Genre = genre;
            Date = date;
            RunTime = runTime;
        }

        public string Title { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public string Date { get; set; }
        public int RunTime { get; set; }


    }
}
