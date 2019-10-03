using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtaketthuocmon
{
    class Cho : DongVat
    {
        public string gau;
        public void keu()
        {
            for (int i = 1; i < 10; i++)
                gau += "gau ";
        }
    }
}
