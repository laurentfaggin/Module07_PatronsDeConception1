using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1
{
    public class Identifiant
    {
        private static Identifiant m_identifiant;
   
        private int m_identifiantUnique;
        private static object m_lock = new object();
        public Identifiant()
        {
            ;
        }

        public static Identifiant IdentifiantUnique
        {
            get
            {
                if (m_identifiant is null)
                {
                    lock (m_lock)
                    {
                        if (m_identifiant is null)
                        {
                            m_identifiant = new Identifiant();
                        }
                    }
                }
                return m_identifiant;
            }
        }

        public int Identifier()
        {
            return ++m_identifiantUnique;
        }
    }
}
