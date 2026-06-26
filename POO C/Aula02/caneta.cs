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
        //Status da caneta mostrando para o usuário
        Console.WriteLine("Uma caneta " + this.cor);
        Console.WriteLine("Uma caneta de ponta " + this.ponta);

        
    }
    public void rabiscar()
    {
        //Validação da caneta tá tampada ou destampada
        if (this.tampada == true)
        {
            Console.WriteLine("Erro: Não posso rabiscar");
        }
        else
        {
            Console.WriteLine("Posso rabiscar");
        }
    }
    
    public void tampar()
    {
        //Atribuição do true no tampada
        tampada = true;
    }

    public void destampar()
    {
        
        this.tampada = false;   
    }
}
