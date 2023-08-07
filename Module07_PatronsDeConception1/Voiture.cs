using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1
{
    public class Voiture
    {
        private int m_identifiant { get; set; }
        private string m_marque { get; set; }
        private string m_modele { get; set; }
        private List<Personne> m_proprietaires { get; set; }


        public Voiture()
        {
            m_identifiant = Identifiant.IdentifiantUnique.Identifier();
        }
        public Voiture(string p_marque, string p_modele)
        {
            m_identifiant = Identifiant.IdentifiantUnique.Identifier();
            m_marque = p_marque;
            m_modele = p_modele;
        }
    }
}
