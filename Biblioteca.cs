using System;

namespace PesquisaDeLivros
{
	public class Autora
	{
		private string _nome { get; set; }

		public Autora()
		{
			
		}
		
		public Autora (string nome)
		{
			_nome = nome;
		}
		public string Nome
			get { return _nome; }
		    set { _nome = value; }
			//set { _nome = $"{value} Pefeita"; }

		}
	}
