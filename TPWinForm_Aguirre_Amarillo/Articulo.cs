using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Aguirre_Amarillo
{
    internal class Articulo
    {
        // --- CONSTRUCTOR ---
        public Articulo(string cod = "000", string nombre = "", string descr = "", string url = "",double precio = 0.00, string marca = "", string categoria = "")
        {
            _cod = cod;
            _nombre = nombre;
            _descr = descr;
            _img = url;
            _precio = precio;
            _marca = new Marca();
            _marca._descMarca = marca;
            _categoria = new Categoria();
            _categoria._descCat = categoria;
        }

        // --- ATRIBUTOS ---
        public string _cod { get; set; }
        public string _nombre { get; set; }
        public string _descr { get; set; }
        public double _precio { get; set; }
        public string _img { get; set; }
        public Marca _marca;
        public Categoria _categoria;

    }
}
