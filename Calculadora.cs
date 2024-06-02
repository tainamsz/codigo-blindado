using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codigo_blindado;
    public class Calculadora
    {
        private List<string> historico = new List<string>();
        private List<int> numeros = new List<int>();

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            AdicionarAoHistorico($"{a} + {b} = {resultado}");
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            AdicionarAoHistorico($"{a} - {b} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            AdicionarAoHistorico($"{a} * {b} = {resultado}");
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            int resultado = a / b;
            AdicionarAoHistorico($"{a} / {b} = {resultado}");
            return resultado;
        }
        private void AdicionarAoHistorico(string operacao)
        {
            if (historico.Count >= 3)
            {
                historico.RemoveAt(0);
            }
            historico.Add(operacao);
        }

        public void ExibirHistorico()
        {
            Console.WriteLine("Últimas três operações:");
            foreach (string operacao in historico)
            {
                Console.WriteLine(operacao);
            }
        }
    }




