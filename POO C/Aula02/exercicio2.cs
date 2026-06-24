using System;

class Hello
{
    public static void Main(string[] args)
    {
        Caneta c1 = new Caneta();
        c1.cor = "Preta";
        c1.ponta = 0.5f;
        c1.tampada = true; 
        
        c1.status();
    }
}
