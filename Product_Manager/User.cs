using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
    internal class User
    {
        private int UserId { get; set; }
        private string Username { get; set; }

        public User(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }

        public int GetUserId()
        {
            return UserId;
        }

        public string GetUsername()
        {
            return Username;
        }




    }
}
