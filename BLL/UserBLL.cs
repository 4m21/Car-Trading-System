using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class UserBLL
    {
        public static List<user> GetUsers (string email, string password)
        {
            return UserDAO.GetUsers(email, password);
        }

        public static void AddUser(user newUser)
        {
            UserDAO.AddUser(newUser);
        }
    }
}
