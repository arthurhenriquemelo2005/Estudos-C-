using System;

public class Caneta
{
    // O '?' evita o aviso (warning) de campo não anulável
    public string? modelo;
    public string? cor;
    public float ponta;
    public int carga;
    public bool tampada;


    public void status()
    {
        Console.WriteLine("Uma caneta " + this.cor);
        Console.WriteLine("Uma caneta de ponta " + this.ponta);

        if (tampada)
        {
            Console.WriteLine("Caneta tampada");
        }
        else
        {
            Console.WriteLine("Caneta destampada");
        }
    }
    public void rabiscar()
    {
        // Seu código aqui
    }

    public void tampar()
    {
        tampada = true;
    }

    public void destampar()
    {
        tampada = false;
    }
}