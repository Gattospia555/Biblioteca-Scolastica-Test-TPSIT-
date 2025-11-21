using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class Libro
    {
        // Attributes
        public string Titolo { get; set; }
        public string Autor { get; set; }
        public string Editore { get; set; }
        public int AnnoDiPubblicazione{ get; set; }
        public int NumeroDiPagine { get; set; }

        // Constructor
        public Libro(string title, string autor, string editor, int yearOfPubblish, int numberOfPages)
        {
            Titolo = title;
            Autor = autor;
            Editore = editor;
            AnnoDiPubblicazione = yearOfPubblish;
            NumeroDiPagine = numberOfPages;
        }
        // Method to show book info
        public void MostraInfo()
        {
            Console.WriteLine($"Titolo: {Titolo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Editore: {Editore}");
            Console.WriteLine($"Anno Di Pubblicazione: {AnnoDiPubblicazione}");
            Console.WriteLine($"Numero Di Pagine: {NumeroDiPagine}");
        }

    }
}
