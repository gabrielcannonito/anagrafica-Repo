using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Alunni
    {
        private string nome;
        private string cognome;
        private int nascita;
        private string codice_fiscale;
        private string luogo;
        private string classe;

        public Alunni(string nome,string cognome,int nascita, string codice_fiscale,string luogo,string classe)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.nascita = nascita;
            this.codice_fiscale = codice_fiscale;
            this.luogo = luogo;
            this.classe = classe;
        }
    }
}
