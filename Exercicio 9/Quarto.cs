using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    internal class Quarto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumeroDoQuarto { get; set; }

        public Quarto(string name, int numeroDoQuarto)
        {
            Name = name;
            NumeroDoQuarto = numeroDoQuarto;
        }

        public Quarto(string name, string email, int numeroDoQuarto) : this (name, numeroDoQuarto)
        { 
            Email = email;         
        }

        public override string ToString()
        {
            return NumeroDoQuarto +
                ": " +
                Name +
                ", " +
                Email;
        }
    }
}
