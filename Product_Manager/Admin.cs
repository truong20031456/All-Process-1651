using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
    internal class Admin
    {
        private int AdminId { get; set; }
        private string Username { get; set; }

        public Admin(int adminId, string username)
        {
            AdminId = adminId;
            Username = username;
        }

        public int GetAdminId()
        {
            return AdminId;
        }

        public string GetUsername()
        {
            return Username;
        }
    }
}

