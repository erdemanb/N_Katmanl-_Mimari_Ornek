using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDepartman
    {
        private string id;
        private string ad;
        private string aciklama;
        //Yukarıda tanımlanan değişkenlerin bulunduğu satırdayken Ctrl+R+E yapınca aşağıdaki propertyleri oluşturuyor.

        public string Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
    }
}
