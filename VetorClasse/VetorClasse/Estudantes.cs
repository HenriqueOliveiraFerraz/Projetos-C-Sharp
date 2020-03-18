using System;
using System.Collections.Generic;
using System.Text;

namespace VetorClasse
{
    class Estudantes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudantes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
