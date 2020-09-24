using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Elenco
    {
        private List<Alunni> elencoAlunni;
        public Elenco()
        {
            elencoAlunni = new List<Alunni>();
        }
        public void Aggiungi (Alunni Unalunno)
        {
            elencoAlunni.Add(Unalunno);
        }
    }
}
