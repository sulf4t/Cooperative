using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Coopérative
    {
        protected string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        protected string _motDePasse;
        public string MotDePasse
        {
            get { return _motDePasse; }
        }

        protected string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        protected string _adresse;
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        protected string _mail;
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        protected int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        protected int _tel;
        public int Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
    }
}
