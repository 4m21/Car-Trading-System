using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserDAO : DbContext
    {
        public static List<user> GetUsers(string email, string password)
        {
            try
            {
                List<user> userList = db.users.Where(x => x.email == email && x.password == password).ToList();
                return userList;
            } 
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void AddUser(user newuUser)
        {
            try
            {
                db.users.InsertOnSubmit(newuUser);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
    }
}
