using System;
using System.Collections.Generic;

namespace PesquisaDeLivros
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Autora autora = new Autora("J. K. Rowling");
			Console.WriteLine(autora.Nome);

			Livro livro = new Livro();
			livro.Titulo = "Harry Potter";
			livro.Autora = autora;
			livro.Preco = 25.90;
			
			Livro livroDois = new Livro();
            {
				Titulo = "Água viva",
				Autora = new Autora("Clarice Lispector"),
				Preco = 35.00
			};


			Livro livroTres = new Livro("titulo", "descricao", 12.99, autora, generos);

			List<Livro> listaLivro = new List<Livro>();
			listaLivro.Add(livro);
			listaLivro.Add(livroDois);

			List<Livro> listaLivro = new List<Livro>();
            {
				livro,
				livroDois
            };

		}
	}
}
