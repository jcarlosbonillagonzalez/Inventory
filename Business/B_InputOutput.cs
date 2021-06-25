using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAcces;
using System.Linq;

namespace Business
{
    public class B_InputOutput
    {
        public List<InputOputEntity> InputOutputList() 
        {
            using (var db = new InventaryContext())
            {
                return db.InOut.ToList();
            }
        }

        public void CreateInputOutput (InputOputEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Add(oInOut);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput (InputOputEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
