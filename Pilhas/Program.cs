using System;
using System.Collections.Generic;

namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> Pilha = new Stack<string>();
            //formando a Pilha com o metodo Push

            Pilha.Push("NUMERO01");
            Pilha.Push("NUMERO002");
            Pilha.Push("NUMERO03");
            Pilha.Push("NUMERO04");
            Pilha.Push("NUMERO05");

            //Removendo o ultimo da pilha
            Pilha.Pop();

            // Mostrando os intens da Pilha
            foreach(String i  in Pilha)
            {
                Console.WriteLine(i);

            }
           

            Console.ReadKey();
        }
    }
}
