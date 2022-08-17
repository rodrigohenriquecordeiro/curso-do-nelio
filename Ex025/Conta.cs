using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeFixacao06
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string titular)
        {
            NumeroConta = numeroDaConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public Conta(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valorDoDeposito)
        {
            Saldo += valorDoDeposito;
        }

        public void Sacar(double valorDoSaque)
        {
            double taxaSaque = 5;
            Saldo -= valorDoSaque + taxaSaque;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: {Saldo:C}";
        }
    }
}
