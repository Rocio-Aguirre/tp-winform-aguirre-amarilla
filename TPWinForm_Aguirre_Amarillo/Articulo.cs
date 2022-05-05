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
        public Articulo(int cod = 0, string nombre = "", string descr = "", double precio = 0)
        {
            _cod = cod;
            _nombre = nombre;
            _descr = descr;
            _precio = precio;
            _marca = new Marca();
            _categoria = new Categoria();
            _Contenedor = new List<Articulo>();
        }

        // --- ATRIBUTOS ---
        public int _cod { get; set; }
        public string _nombre { get; set; }
        public string _descr { get; set; }
        public double _precio { get; set; }
        private int _numAux;

        // no se como se puede tener la img en la clase, supongo un mapa de bits o una url/dir donde este la img
        // lo dejo como un string por ahora
        public string _img { get; set; }
        public Marca _marca;
        public Categoria _categoria;
        public List<Articulo> _Contenedor = null;

        // --- METODOS ---
        public void Cargar(int p_cod, string p_nombre, string p_desc, double p_precio)
        {
            _Contenedor.Add( new Articulo( p_cod, p_nombre, p_desc, p_precio ) ); 
        }
        //
        // Para identificar un registro a eliminar, podemos a partir del: codigo, el nombre, marca, categoria o precio
        // obs: Eliminiara todo registro que cumpla la condicion, ej: si hay mas de 1 registro con un precio buscado, eliminara los 2
        public bool Eliminar(int p_cod)
        {
            _numAux = _Contenedor.RemoveAll(obj =>
            {
                if (obj._cod == p_cod) return true;
                else return false;
            });
            if (_numAux != 0) return true;
            else return false;
        }
        public bool Eliminar(string p_str)
        {
            _numAux = _Contenedor.RemoveAll(obj =>
            {
                if (obj._nombre == p_str) return true;
                else if (obj._descr == p_str) return true;
                else if (obj._marca._nombMarca == p_str) return true;
                else return false; 
            });
            if (_numAux != 0) return true;
            else return false;
        }
        public bool Eliminar(double p_prec)
        {
            _numAux = _Contenedor.RemoveAll(obj =>
            {
                if(obj._precio == p_prec) return true;
                else return false;
            });
            if (_numAux != 0) return true;
            else return false;
        }

        //
        // Para identificar un registro a modificar, usamos el codigo de articulo
        public bool ModificarCodigo(int p_cod)
        {
            foreach (var obj in _Contenedor)
            {
                if (obj._cod == p_cod)
                {
                    obj._cod = p_cod;
                    return true;
                }
            }
            return false;
        }
        public bool ModificarNombre(int p_cod, string p_str)
        {
            foreach (var obj in _Contenedor)
            {
                if (obj._cod == p_cod)
                {
                    obj._nombre = p_str;
                    return true;
                }
            }
            return false;
        }
        public bool ModificarPrecio(int p_cod, double p_prec)
        {
            foreach (var obj in _Contenedor)
            {
                if (obj._cod == p_cod)
                {
                    obj._precio = p_prec;
                    return true;
                }
            }
            return false;
        }
        public bool ModificarDesc(int p_cod, string p_desc)
        {
            _flag = false;
            foreach (var obj in _Contenedor)
            {   
                if (obj._cod == p_cod) 
                { 
                    obj._descr = p_desc; 
                    return true;
                }
            }
            return false;
        }
        public bool ModificarCategoria(int p_cod, int p_cat)
        {
            foreach (var obj in _Contenedor)
            {
                if (obj._cod == p_cod)
                {
                    obj._categoria._numCat = p_cat;
                    return true;
                }
            }
            return false;
        }

        //
        public int Seleccionar_x_id(int p_cod)
        {
            foreach( var obj in _Contenedor)
            {
                if (obj._cod == p_cod) return _Contenedor.IndexOf(obj);
            }
            return -1;
        }

    }
}
