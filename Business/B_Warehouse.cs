using DataAcces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> warehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void CreateWarehouse (WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse (WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            { 
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
