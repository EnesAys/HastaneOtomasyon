using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonDATA;
namespace HastaneOtomasyonLIB
{
    public class RandevuRepo : IRepository<Randevu>
    {
        HastaneEntities db = new HastaneEntities();
        public void Delete(int itemID)
        {
            db.Randevus.Remove(db.Randevus.Find(itemID));
            db.SaveChanges();
        }
        public List<Doktor> SelectDoktor()
        {
            return db.Doktors.ToList();
        }
        public List<Hasta> SelectHasta()
        {
            return db.Hastas.ToList();
        }
        public List<Birim> SelectBirim()
        {
            return db.Birims.ToList();
        }
        public void Insert(Randevu item)
        {
            db.Randevus.Add(item);
            db.SaveChanges();
        }

        public List<Randevu> SelectAll()
        {
            return db.Randevus.ToList();
        }

        public Randevu SelectByID(int itemID)
        {
            return db.Randevus.Find(itemID);
        }

        public void Update(Randevu item)
        {
            Randevu guncellenecek = db.Randevus.Find(item.RandevuID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
