using ListaAppuntamenti;


List<Appuntamento> nuovaListaAppuntamenti = new List<Appuntamento>();

Console.Write("Quanti appuntamenti vuoi aggiungere? : ");
int numeriAppuntamenti = Convert.ToInt32(Console.ReadLine());



for (int i = 0; i< numeriAppuntamenti; i++)
{
  

    Console.Write("Aggiungi nome : ");
    string? nome = Console.ReadLine();
    while (nome == null)
    {
        nome = Console.ReadLine();
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
            Console.Write("Aggiungi data : ");
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


