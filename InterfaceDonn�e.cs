using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    interface InterfaceDonnee
    {
        public Client connecterCLient(string identifiant, string motDePasse);
        public void inscrireClient(string nom, string prenom, string motDePasse, string adresse, string mail, int age, int tel);
    }
}
