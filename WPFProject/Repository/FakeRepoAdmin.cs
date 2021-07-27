using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.Repository
{
    public class FakeRepoAdmin
    {
        public List<Admin> Admins { get; set; }

        public List<Admin> GetAdmins()
        {
            return Admins;
        }
    }
}
