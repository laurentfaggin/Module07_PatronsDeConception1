﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_PatronsDeConception1.Affichage_De_Formes
{
    public class Cercle
    {
        public Affichage affichage { get; set; }
        public Cercle(Affichage p_affichage)
        {           
            affichage = p_affichage;
        }
    }
}
