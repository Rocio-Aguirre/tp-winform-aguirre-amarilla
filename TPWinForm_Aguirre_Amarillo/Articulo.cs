using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Aguirre_Amarillo
{
    internal class Articulo
    {
        // CONSTRUCTOR

        public Articulo(int cod = 0, string nombre = "", string descr = "", float precio = 0)
        {
            _cod = cod;
            _nombre = nombre;
            _descr = descr;
            _precio = precio;
            _marca = new Marca();
            _categoria = new Categoria();
        }

        // ATRIBUTOS
        public int _cod { get; set; }
        public string _nombre { get; set; }
        public string _descr { get; set; }
        public float _precio { get; set; }

        // no se como se puede tener la img en la clase, supongo un mapa de bits o una url/dir donde este la img
        // lo dejo como un string por ahora
        public string _img { get; set; }
        public Marca _marca;
        public Categoria _categoria;

        // METODOS
    }
}
