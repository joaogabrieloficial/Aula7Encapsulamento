using System;

namespace Aula7Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           Mastercard master =new Mastercard();
           master.titular = "Joao";
           master.numero = "69858287";
           master.bandeira = "Visa";
           master.parcelas = 10 ;
           master.ComprarComDescontoMastercard (45f);
           System.Console.WriteLine(master.AprovarCompra());
           
        }
    }
}
