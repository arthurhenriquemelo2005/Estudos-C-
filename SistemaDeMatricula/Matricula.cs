using System;
using System.Runtime.CompilerServices;

class Matricula
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o seu nome: ");
        string nomeAluno = Console.ReadLine()?? "";

        Console.WriteLine("Qual seu curso: ");
        string nomeCurso = Console.ReadLine()?? "";

        Console.WriteLine("Qual se turno: ");
        string turnoAluno = (Console.ReadLine()??"").ToLower();
        if(turnoAluno != "manhã" &&
        turnoAluno != "tarde" &&
        turnoAluno != "noite")
        {
            Console.WriteLine("Não existe esse turno");
            return;
        }

        Console.Clear();
        Console.WriteLine(" === MATRÍCULA REALIZADA === ");
        Console.WriteLine($"Aluno: {nomeAluno} ");
        Console.WriteLine($"Curso: {nomeCurso}");
        Console.WriteLine($"Turno: {turnoAluno}");

    }
}