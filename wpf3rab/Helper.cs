using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;

namespace wpf3rab
{
    class Helper
    {
        private static Models.Entities s_entities;
        public static Models.Entities getContext()
        {
            if(s_entities == null)
            {
                s_entities = new Models.Entities();
            }
            return s_entities;
        }
        public void CreateUsers(Models.Autorizacia user)
        {
            s_entities.Autorizacia.Add(user);
            s_entities.SaveChanges();
        }
        public void UpdateUsers(Models.Autorizacia user)
        {
            s_entities.Entry(user).State = EntityState.Modified;
            s_entities.SaveChanges();
        }

    }
}
