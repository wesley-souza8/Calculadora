using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            // Usando Stack para armazenar os resultados
            Stack<decimal> resultados = new Stack<decimal>();

            // Colcando uma apresentação inicial
            Console.WriteLine("Case Calculadora - Wesley Souza de Oliveira\n");
            Console.WriteLine("Bem vinda(o) a Calculadora\n");

            // Ajuste no loop para sair do valor inicial
            while (filaOperacoes.Count > 0)
            {
                // Ajuste no loop para sair do valor inicial
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("Calculando:\n{0} {1} {2} = {3}\n", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // Armazenando o resultado na pilha
                resultados.Push(operacao.resultado);

                // Imprimindo os próximos na fila
                Console.WriteLine("Próximos na fila:");
                foreach (Operacoes op in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
                }
                Console.WriteLine();
            }

            // Imprimindo todos os resultados calculados na ordem que foi calculado
            Console.WriteLine("Todos os resultados calculado:");
            foreach (decimal i in resultados.Reverse())
            {
                Console.WriteLine(i);
            }          
           
        }
    }
}
