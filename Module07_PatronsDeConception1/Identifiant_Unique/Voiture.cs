using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1.NewFolder
{
    public class Voiture
    {
        public int identifiant { get; private set; }
        private string m_marque { get; set; }
        private string m_modele { get; set; }
        private List<Personne> m_proprietaires { get; set; }


        public Voiture()
        {
            identifiant = Identifiant.Instance.Identifier();
        }
        public Voiture(string p_marque, string p_modele)
        {
            identifiant = Identifiant.Instance.Identifier();
            m_marque = p_marque;
            m_modele = p_modele;
        }
        public void AjouterProprietaire(Personne person)
        {
            m_proprietaires.Add(person);
        }
    }
}
