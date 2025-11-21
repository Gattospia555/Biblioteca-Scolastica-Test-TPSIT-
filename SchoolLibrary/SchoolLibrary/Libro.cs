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
        public int AnnoDiPubblicazione { get; set; }
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

        public void SalvaSuFile(string percorsoFile)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("libri.txt"))
            {
                file.WriteLine(Titolo);
                file.WriteLine(Autor);
                file.WriteLine(Editore);
                file.WriteLine(AnnoDiPubblicazione);
                file.WriteLine(NumeroDiPagine);
            }
        }

        public void CecaInFile(string percorsoFile, string titoloDaCercare)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader("libri.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line == titoloDaCercare)
                    {
                        Console.WriteLine("Libro trovato:");
                        Console.WriteLine(line);
                        return;
                    }
                }
                Console.WriteLine("Libro non trovato.");
            }
        }

        public void RicercaPerAutore(string percorsoFile, string autoreDaCercare)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader("libri.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line == autoreDaCercare)
                    {
                        Console.WriteLine("Libro trovato:");
                        Console.WriteLine(line);
                        return;
                    }
                }
                Console.WriteLine("Libro non trovato.");
            }
        }

        public void NumeroDiLibriInFile(string percorsoFile)
        {
            int count = 0;
            using (System.IO.StreamReader file = new System.IO.StreamReader("libri.txt"))
            {
                while (file.ReadLine() != null)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numero di libri nel file: {count / 5}"); // Assuming each book has 5 lines of info
        }
    }
}
