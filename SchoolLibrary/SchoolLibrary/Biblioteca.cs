using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class Biblioteca
    {
        class InfoBiblioteca
        {
            public string Nome { get; set; }
            public string Indirizzo { get; set; }
            public string OrarioApertura { get; set; }
            public string OrarioChiusura { get; set; }
            Libro[] LibriDisponibili { get; set; }
        }
    }
}
