using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugizad
{
    class KlasaD
    {
        public bool Suprotno(bool vrijdenost)
        {
            bool suprotno = !vrijdenost;
            return suprotno;
        }

        public int Suprotno(int broj)
        {
            int suprotno = broj*-1;
            return suprotno;

        }

    }
}
