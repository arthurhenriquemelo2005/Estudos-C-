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
        //.ToLower para mandar tudo em minúsculo
        string turnoAluno = (Console.ReadLine()??"").ToLower();
        //Validações de turnos
        if(turnoAluno != "manhã" &&
        turnoAluno != "tarde" &&
        turnoAluno != "noite")
        {
            Console.WriteLine("Não existe esse turno");
            return; //(return) para parar o sistema aqui
        }

        Console.Clear(); // Limpar a tela
        Console.WriteLine(" === MATRÍCULA REALIZADA === ");
        Console.WriteLine($"Aluno: {nomeAluno} ");
        Console.WriteLine($"Curso: {nomeCurso}");
        Console.WriteLine($"Turno: {turnoAluno}");

    }
}
