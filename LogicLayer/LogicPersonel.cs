using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DalPersonel.PersonelListesi();
        }
        //Aşağıdaki koşul ifadesi, mantıklı olmayan işlemlerin yapılmamasını sağlar. 
        public static int LLPersonelEkle(EntityPersonel p) {
            if (p.Ad != "" && p.Sehir != "" && p.Maas >= 10000 && p.Ad.Length >= 2)
            {
                return DalPersonel.PersonelEkle(p);

            }
            else
                return -1;
        }
        public static bool LLPersonelSil(int per)
        {
            if (per>=1)
            {
                return DalPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGuncelle(EntityPersonel entity)
        {
            if(entity.Ad !="" && entity.Sehir !=""&& entity.Maas >= 10000)
            {
                return DalPersonel.PersonelGuncelle(entity);
            }
            else { return false; }  
        }
    }
    
}
