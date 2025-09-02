﻿using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+':
                    operacao.resultado= soma(operacao);
                break;
                case '-':
                    operacao.resultado = subtracao(operacao);
                break;
                case '*': 
                    operacao.resultado = multiplicacao(operacao);
                break;

                // Implementação da divisão
                case '/': 
                    operacao.resultado = divisao(operacao);
                break;
                default:
                    operacao.resultado = 0;
                break;
            }
            return operacao;
        }

        // Ajuste dos métodos para usar decimal
        public decimal soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public decimal subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public decimal multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }       
        public decimal divisao(Operacoes operacao)
        {
            // Tratamento para divisão por zero
            if (operacao.valorB == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return operacao.valorA / operacao.valorB;
        }
       
    }
}
