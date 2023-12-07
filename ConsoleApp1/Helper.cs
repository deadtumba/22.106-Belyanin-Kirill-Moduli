using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using ConsoleApp1.Models1;
namespace ConsoleApp1
{
    class Helper1
    {
        private static Entities1 s_entities1;
        public static Entities1 GetContext()
        {
            if(s_entities1 == null)
            {
                s_entities1 = new Entities1();
            }
            return s_entities1;
        }
        public void CreateUsers(Autorizacia user)
        {
            s_entities1.Autorizacia.Add(user);
            s_entities1.SaveChanges();
        }
        public void UpdateUsers(Autorizacia user)
        {
            s_entities1.Entry(user).State = EntityState.Modified;
            s_entities1.SaveChanges();
        }

    }
}
