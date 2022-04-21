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
			this.dataOra = dataOra;
			ControlloDataEsatta();
			this.nome = nome;
			this.localitaAppuntamento = localitaAppuntamento;
			
		}

		public void ControlloDataEsatta()
        {
			
			DateTime dataOraAttuale = DateTime.Now;

			if (dataOra <= dataOraAttuale)
            {
				throw new ArgumentOutOfRangeException("Non puoi inserire data nel passato");
            } 
        }

		public DateTime CambioData(DateTime nuovaData)
        {
			this.dataOra = nuovaData;
			ControlloDataEsatta();
			return dataOra;
        }

        public override string ToString()
        {
			Console.WriteLine("La data è: " + dataOra);
			Console.WriteLine("Il nome è: " + nome);
			Console.WriteLine("La località è: " + localitaAppuntamento);
			return base.ToString();
        }
    }
}

