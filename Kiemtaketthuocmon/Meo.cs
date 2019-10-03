using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtaketthuocmon
{
    class Meo : DongVat
    {
        public string meo;
        public void keu()
        {
            for(int i=1; i<10; i++)
            meo += "meo ";
        }
    }
}
