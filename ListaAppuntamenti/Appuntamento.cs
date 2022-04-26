using System;
namespace ListaAppuntamenti
{
	public class Appuntamento
	{
		private DateTime dataOra;
		private string nome { get; set; }
		private string localitaAppuntamento { get; set; }

		public Appuntamento(DateTime dataOra, string nome, string localitaAppuntamento)
		{
			this.dataOra = dataOra;
			ControlloDataEsatta();
			this.nome = nome;
			this.localitaAppuntamento = localitaAppuntamento;
			
		}

		public string GetNome()
        {
			return nome;
        }

		public string GetLocalitaAppuntamento()
		{
			return localitaAppuntamento;
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
			string appuntamentoCompleto = "------ \n Appuntamento" + nome + "\n Località:" + localitaAppuntamento + "\n in data:" + dataOra;
			return appuntamentoCompleto;
        }
    }
}

