using System;

class Objetos
{
    public static void Main(string[] args)
    {
        Caneta c1 = new Caneta();
        c1.cor = "Preta";
        c1.ponta = 0.5f;
        
        c1.tampar();
        c1.status();
        c1.rabiscar();

        Caneta c2 = new Caneta();

        c2.modelo = "Bic";
        c2.cor = "Azul";
        
        c2.destampar();
        c2.status();
        c2.rabiscar();
    }
}
