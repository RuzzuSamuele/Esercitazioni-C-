using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_pratica__arrayList_
{
    class Person
    {
        public string Name { set; get; }
        public int Eta { set; get; }

        public int Peso { set; get; }

        public int Altezza { set; get; }

        public Person(string nome, int eta, int peso, int altezza)
        {
            Name = nome;
            Eta = eta;
            Peso = peso;
            Altezza = altezza;
        }
        override
        public string ToString()
        {
            return $"Sono la persona {Name} e ho {Eta} anni e peso {Peso} kg di altezza {Altezza} cm.";
        }
    }
}
