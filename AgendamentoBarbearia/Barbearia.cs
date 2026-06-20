using System;

class Barbearia
{
    static void Main(string[] args)
    {
        bool loop = true;
        string corteEscolhido = "";
        //Declarando lista
        List<TimeOnly> listaHorarios = new List<TimeOnly>();

        TimeOnly abertura = new TimeOnly (8,0);
        TimeOnly fechamento = new TimeOnly(22,0);
        

        while (loop)
        {
            Console.WriteLine("[1] Agendar horário");
            Console.WriteLine("[2] Ver horários agendados");
            Console.WriteLine("[3] Cancelar agendamento");
            Console.WriteLine("[4] Sair");

        Console.WriteLine("Escolha uma das opções: ");
        int escolha = int.Parse(Console.ReadLine()?? "");
            
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Informe seu nome");
                    string nomeCliente = Console.ReadLine() ?? "";
                    Console.Clear();
                    Console.WriteLine("[1] Degradê");
                    Console.WriteLine("[2] Cabelo e Barba");
                    Console.WriteLine("[3] Corte na Tesoura");
                    Console.WriteLine("Qual opção de corte: ");
                    int opcaoCorte = int.Parse(Console.ReadLine() ?? "");

                    
                    Console.Clear();
                    switch (opcaoCorte)
                    {
                        case 1:
                            
                            corteEscolhido = "Degradê";
                            break;
                        
                        case 2:

                            corteEscolhido = "Corte e Barba";
                            break;
                        
                        case 3:

                            corteEscolhido = "Corte na Tesoura";
                            break;

                    } 

                    Console.WriteLine("Digite horário do agentamento (Ex: 15:25)");
                    TimeOnly horaAgendamento = TimeOnly.Parse(Console.ReadLine() ?? "");

                    if (horaAgendamento < abertura || horaAgendamento > fechamento) {
                        
                        Console.WriteLine($"A barbearia funciona das {abertura} até as {fechamento}");
                        break;
                    }
                    if (listaHorarios.Contains(horaAgendamento))
                    {
                        Console.WriteLine($"Horário indisponivel o horário {horaAgendamento} já esta ocupado");
                        break;
                    }

                    listaHorarios.Add(horaAgendamento);
                    
                    Console.Clear();
                    Console.WriteLine($"=== AGENDAMENTO REALIZADO ===");
                    Console.WriteLine($"Cliente: {nomeCliente}");
                    Console.WriteLine($"Modelo de corte: {corteEscolhido}");
                    Console.WriteLine($"Horario agendado: {horaAgendamento}");
                    
                    break;
                case 2:

                    Console.WriteLine("=== HORÁRIO DE AGENDAMENTOS ===");
                    
                    if(listaHorarios.Count == 0)
                    {
                        Console.WriteLine("Nenhum horário agendado até o momento");
                    }
                    else
                    {
                        for(int i = 0; i< listaHorarios.Count; i++)
                        {
                            Console.WriteLine($"Agendamentos {i + 1}: {listaHorarios[i].ToString ("HH:mm")}");
                        }
                    }

                    break;
                
                case 3:

                if(listaHorarios.Count == 0)
                    {
                        Console.WriteLine("Não tem agendamentos, portanto não tem como ser cancelado");
                        break;                      
                    }
                    
                    Console.WriteLine("Deseja cancelar agendamento (s/n)");
                    char cancelarAgendamento = char.ToLower(Console.ReadKey().KeyChar);
                    if(cancelarAgendamento == 's')
                    {
                        for(int i = listaHorarios.Count -1; i >= 0; i--)
                        {
                            listaHorarios.RemoveAt(i);
                            Console.Clear();
                            Console.WriteLine($"Agendamento Cancelado cancelado");

                            break;
                        }
                        
                    }else if(cancelarAgendamento == 'n')
                    {
                        Console.Clear();
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
                
                default:
                    
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

    }
}