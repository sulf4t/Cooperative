using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    public class Usecase
    {
        private Dictionary<string, Client> _listClient = new Dictionary<string, Client>();


        public Client connecterCLient(string identifiant, string motDePasse)
        {
            
            if (_listClient.ContainsKey(identifiant))
            {
                Client clientObtain;
                _listClient.TryGetValue(identifiant, out clientObtain);
                if (clientObtain.MotDePasse.Equals(motDePasse))
                {
                    return clientObtain;
                }
            }
            return null;
        }

        public void inscrireClient(string nom, string prenom, string motDePasse, string adresse, string mail, int age, int tel)
        {
            Client client = new Client(nom, prenom, motDePasse, adresse, mail, age, tel);
            _listClient.Add(nom,client);
        }


    }
}
