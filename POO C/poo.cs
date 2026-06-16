using System;

class Mouse
{
    public string modelo;
    public string cor;
    public bool funcionando;
    public bool fio;


    public void Mexer()
    {
        if (funcionando)
        {
            Console.WriteLine("Pode mexer");
        }
        else
        {
            Console.WriteLine("Não pega");
        }
    }


    public void Plugar()
    {
        fio = true;
        Console.WriteLine("Mouse conectado no computador");
    }
}

class Teclado{
    public string modelo;

    public string cor;
    
    public string tamanho;
    public bool funcionando;

    public bool fio ;

    public void Mexer()
    {
        if (funcionando)
        {
            Console.WriteLine("Pode teclar");
        }
        else
        {
            Console.WriteLine("Teclado quebrado");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {

        Mouse m1 = new Mouse();
        m1.modelo = "Gamer";
        m1.cor = "Preto";
        m1.funcionando = true;
        m1.fio = true;


        m1.Plugar();
        m1.Mexer();

        Console.WriteLine();

        Mouse m2 = new Mouse();
        m2.modelo = "Empresarial";
        m2.cor = "Cinza";
        m2.funcionando = true;
        m2.fio = true;


        m2.Plugar();
        
        Console.WriteLine();


        Teclado t1 = new Teclado();
        t1.modelo = "gamer";
        t1.cor = "preto";
        t1.tamanho = "médio";
        t1.funcionando = true;
        t1.fio = true;

        t1.Mexer();

    }
}