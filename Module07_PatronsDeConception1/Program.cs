using Module07_PatronsDeConception1.Affichage_De_Formes;
using Module07_PatronsDeConception1.NewFolder;

namespace Module07_PatronsDeConception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread w = new Thread(Worker);
            w.Start();
            Thread.Sleep(1000);
            Voiture voiture = new Voiture();
            Voiture voiture2 = new Voiture();
            Voiture voiture3 = new Voiture();

            Personne personne = new Personne();
            Personne personne2 = new Personne();
            Personne personne3 = new Personne();

            List<Voiture> voitures = new List<Voiture> { voiture, voiture2, voiture3 };
            List<Personne> personnes = new List<Personne> { personne, personne2, personne3 };

            voitures.ForEach(v => Console.WriteLine(v.identifiant + "voiture main"));
            personnes.ForEach(p => Console.WriteLine(p.identifiant + "personne main"));
            w.Join();
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }


            Affichage affiche = new AffichageDessin();
            Rectangle rect = new Rectangle(affiche);
            rect.affichage.MethodeAffichage();

            Affichage afficheEcran = new AffichageEcran();
            Cercle cercle = new Cercle(afficheEcran);
            cercle.affichage.MethodeAffichage();
        }

        static void Worker()
        {
            Thread.Sleep(00);
            Voiture voiture = new Voiture();
            Voiture voiture2 = new Voiture();
            Voiture voiture3 = new Voiture();

            Personne personne = new Personne();
            Personne personne2 = new Personne();
            Personne personne3 = new Personne();

            List<Voiture> voitures = new List<Voiture> { voiture, voiture2, voiture3 };
            List<Personne> personnes = new List<Personne> { personne, personne2, personne3 };

            voitures.ForEach(v => Console.WriteLine(v.identifiant + "voiture worker"));
            personnes.ForEach(p => Console.WriteLine(p.identifiant + "personne worker"));
        }
    }
}