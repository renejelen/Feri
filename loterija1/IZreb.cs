using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loterija
{
    public interface IZreb
    {
        public void vplaciloKombinacije(Kombinacija kombinacija);
        public void nakljucnaVplacila();
        public void priprava(DateTime dateTime);
        public void izvedba();
    }
}
