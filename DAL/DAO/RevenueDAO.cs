using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class RevenueDAO :DbContext
    {
        public static List<revenue> GetRevenue()
        {
            return db.revenues.ToList();
        }


        // new changes
        // add revenue
        public static void AddRevenue(revenue rev)
        {
            try
            {
                db.revenues.InsertOnSubmit(rev);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
