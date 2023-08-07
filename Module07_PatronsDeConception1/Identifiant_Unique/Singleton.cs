using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1.NewFolder
{
    public class Singleton<TypeElement> where TypeElement:new()
    {
        private static TypeElement m_instance;
        private static object m_lock = new object();

        public static TypeElement Instance
        {
            get
            {
                if (m_instance is null)
                {
                    lock (m_lock)
                    {
                        if (m_instance == null)
                        {
                            m_instance = new TypeElement();
                        }
                    }
                }
                return m_instance;
            }
        }
    }
}
