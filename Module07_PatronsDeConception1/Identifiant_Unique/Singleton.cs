using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1.NewFolder
{
    public class Singleton
    {
        private static Singleton m_instance;
        private static object m_lock = new object();

        public static Singleton Instance
        {
            get
            {
                if (m_instance is null)
                {
                    lock (m_lock)
                    {
                        if (m_instance == null)
                        {
                            m_instance = new Singleton();
                        }
                    }
                }
                return m_instance;
            }
        }
    }
}
