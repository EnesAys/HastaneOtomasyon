using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonDATA;

namespace HastaneOtomasyonLIB
{
    public class HastaRepository:IRepository<Hasta>
    {
        HastaneEntities db = new HastaneEntities();
        public void Insert(Hasta item)
        {
            db.Hastas.Add(item);
            db.SaveChanges();
        }

        public void Update(Hasta item)
        {
            Hasta guncellenecek = db.Hastas.Find(item.HastaID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemID)
        {
            db.Hastas.Remove(db.Hastas.Find(itemID));
            db.SaveChanges();
        }

        public List<Hasta> SelectAll()
        {
            return db.Hastas.ToList();
        }

        public Hasta SelectByID(int itemID)
        {
           return db.Hastas.Find(itemID);
        }

        
    }
}
