using System;
using System.Collections.Generic;
using System.Text;

namespace TemaSalarios
{
    class Salario
    {
        // Variáveis
        private int _id;
        private string _nome;
        private double _salario;
        public Salario(int id, string nome, double salario) // Construtor
        {
            _id = id;
            _nome = nome;
            _salario = salario;
        }
        public void aumentarSalario(double porcentagem) // Altera o salário baseado na porcentagem
        {
            _salario += (_salario * porcentagem / 100);
        }
        public int ID // Properties do _id
        {
            get { return _id; }
        }
        public string Nome // Properties do _nome
        {
            get { return _nome; }
        }
        public double Pagamento // Properties do _salario
        {
            get { return _salario; }
        }
    }
}
