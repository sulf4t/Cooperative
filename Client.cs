using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    public class Client : Coopérative
    {

        public Client(string nom, string prenom, string motDePasse, string adresse, string mail, int age, int tel)
        {
            _nom = nom;
            _prenom = prenom;
            _motDePasse = motDePasse;
            _adresse = adresse;
            _mail = mail;
            _age = age;
            _tel = tel;
        }
            
    }
}
