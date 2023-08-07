using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1.NewFolder
{
    public class Personne
    {
        public int identifiant { get; private set; }
        private string m_name { get; set; }
        private string m_prenom { get; set; }
        private List<Voiture> m_voitures { get; set; }

        public Personne()
        {
            identifiant = Identifiant.Instance.Identifier();
        }

        public Personne(string p_name, string p_prenom)
        {
            identifiant = Identifiant.Instance.Identifier();
            m_name = p_name;
            m_prenom = p_prenom;
        }
        public void AjouterVoiture(Voiture voiture)
        {
            m_voitures.Add(voiture);
        }
    }
}
