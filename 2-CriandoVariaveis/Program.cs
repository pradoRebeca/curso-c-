using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade = 17;

        double salario = 2003.45;

        int salarioInteriro;

        //Transformar tipo double em tipo int
        salarioInteriro = (int)salario;

        //tranformar cacartere em numero 
        char letra = 'b';

        letra = (char)65;


        //Separação de itens em uma string
        string cursos = @"Cursos: 
            -A 
            -B 
            -C 
            -D";






        Console.WriteLine("Pressione enter...");
        Console.ReadLine();
    }

}




