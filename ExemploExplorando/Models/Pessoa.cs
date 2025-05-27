using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome :{NomeCompleto}, Idade: {Idade} anos");
        }

    }
}
