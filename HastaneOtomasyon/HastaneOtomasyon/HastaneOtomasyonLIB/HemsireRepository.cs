using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonDATA;

namespace HastaneOtomasyonLIB
{
    public class HemsireRepository : IRepository<Hemsire>
    {
        HastaneEntities db = new HastaneEntities();
        public void Delete(int itemID)
        {
            db.Hemsires.Remove(db.Hemsires.Find(itemID));
            db.SaveChanges();
        }
        public List<Birim> SelectBirim()
        {
            return db.Birims.ToList();
        }
        public List<Doktor> SelectDoktor()
        {
            return db.Doktors.ToList();
        }

        public void Insert(Hemsire item)
        {
            db.Hemsires.Add(item);
            db.SaveChanges();
        }

        public List<Hemsire> SelectAll()
        {
            return db.Hemsires.ToList();
        }

        public Hemsire SelectByID(int itemID)
        {
            return db.Hemsires.Find(itemID);
        }

        public void Update(Hemsire item)
        {
            Hemsire guncellenecek = db.Hemsires.Find(item.HemsireID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
