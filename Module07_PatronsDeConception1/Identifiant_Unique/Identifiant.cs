using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1.NewFolder
{
    public class Identifiant: Singleton<Identifiant>
    {
        private int m_identifiantUnique;
        public Identifiant()
        {
            ;
        }

       

        public int Identifier()
        {
            return ++m_identifiantUnique;
        }
    }
}
