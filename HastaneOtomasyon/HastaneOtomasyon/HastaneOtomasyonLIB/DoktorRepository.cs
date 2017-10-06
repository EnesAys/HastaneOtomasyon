using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonDATA;

namespace HastaneOtomasyonLIB
{
    public class DoktorRepository : IRepository<Doktor>
    {
        HastaneEntities db = new HastaneEntities();
        public void Delete(int itemID)
        {
            db.Doktors.Remove(db.Doktors.Find(itemID));
            db.SaveChanges();
        }
        public List<Birim> SelectBirim()
        {
            return db.Birims.ToList();
        }
        public void Insert(Doktor item)
        {
            db.Doktors.Add(item);
            db.SaveChanges();
        }

        public List<Doktor> SelectAll()
        {
            return db.Doktors.ToList();
        }

        public Doktor SelectByID(int itemID)
        {
            return db.Doktors.Find(itemID);
        }

        public void Update(Doktor item)
        {
            Doktor guncellenecek = db.Doktors.Find(item.DoktorID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
