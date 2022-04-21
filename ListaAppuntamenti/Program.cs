using ListaAppuntamenti;


List<Appuntamento> nuovaListaAppuntamenti = new List<Appuntamento>();

Console.Write("Quanti appuntamenti vuoi aggiungere? : ");
int numeriAppuntamenti = Convert.ToInt32(Console.ReadLine());



for (int i = 0; i< numeriAppuntamenti; i++)
{
  

    Console.Write("Aggiungi nome : ");
    string? nome = Console.ReadLine().ToLower();
    while (nome == null)
    {
        nome = Console.ReadLine().ToLower();
    }
    
    Console.Write("Aggiungi Località : ");
    string? localitaAppuntamento = Console.ReadLine();
    while (localitaAppuntamento == null)
    {
        localitaAppuntamento = Console.ReadLine();
    }

    bool dataCorretta = false;
    while (!dataCorretta)
    {
        DateTime dataOra = DateTime.Now;
        bool formatoDataCorretto = false;
        while (!formatoDataCorretto)
        {
            Console.Write("Aggiungi data [gg/mm/aaaa] e ora [00:00] : ");
            try
            {
                dataOra = DateTime.Parse(Console.ReadLine());
                formatoDataCorretto = true;
            } catch (Exception)
            {
                Console.WriteLine("Il formato non è corretto");
            }
        }
        
        
        try
        {
            
            nuovaListaAppuntamenti.Add(new Appuntamento(dataOra, nome, localitaAppuntamento));
            dataCorretta = true;
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    
}

foreach (Appuntamento appuntamento in nuovaListaAppuntamenti)
{
    appuntamento.ToString();
}




while (true)
{
    Console.Write("Vuoi modificare un appuntamento? (si/no): ");
    string scelta = Console.ReadLine().ToLower();

    switch (scelta)
    {
        case "si":
            bool trovato = false;
            Console.Write("Nome appuntamento: ");
            string nomeAppuntamento = Console.ReadLine().ToLower();

            foreach (Appuntamento appuntamento in nuovaListaAppuntamenti)
            {

                if (appuntamento.GetNome() == nomeAppuntamento)
                {
                    trovato = true;
                    bool dataCorretta = false;
                    while (!dataCorretta)
                    {
                        DateTime dataOra = DateTime.Now;
                        bool formatoDataCorretto = false;
                        while (!formatoDataCorretto)
                        {
                            Console.Write("Aggiungi nuova data [gg/mm/aaaa] e ora [00:00] : ");
                            try
                            {
                                dataOra = DateTime.Parse(Console.ReadLine());
                                formatoDataCorretto = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Il formato non è corretto");
                            }
                        }


                        try
                        {
                            appuntamento.CambioData(dataOra);

                            dataCorretta = true;
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }

                }
            }

            foreach (Appuntamento appuntamento in nuovaListaAppuntamenti)
            {
                appuntamento.ToString();
            }
            break;
        case "no":
            Console.WriteLine("Grazie");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Mi dispiace opzione non contemplata");
            break;
    }
}





