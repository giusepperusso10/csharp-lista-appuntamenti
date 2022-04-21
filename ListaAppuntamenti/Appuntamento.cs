using System;
namespace ListaAppuntamenti
{
	public class Appuntamento
	{
		private DateTime dataOra;
		private string nome { get; }
		private string localitaAppuntamento { get; }

		public Appuntamento(DateTime dataOra, string nome, string localitaAppuntamento)
		{
			this.dataOra = ControlloDataEsatta(dataOra);
			this.nome = nome;
			this.localitaAppuntamento = localitaAppuntamento;
			
		}

		public DateTime ControlloDataEsatta(DateTime dataOra)
        {
			this.dataOra = dataOra;
			DateTime dataOraAttuale = DateTime.Now;

			if (dataOra >= dataOraAttuale)
            {
				Console.WriteLine("Data accettata");
				return dataOra;
            } else
            {
				Console.WriteLine("Data non accettata");
			}
			return dataOra;
        }

		public DateTime CambioData(DateTime nuovaData)
        {
			this.dataOra = ControlloDataEsatta(nuovaData);
			return dataOra;
        }
	}
}

