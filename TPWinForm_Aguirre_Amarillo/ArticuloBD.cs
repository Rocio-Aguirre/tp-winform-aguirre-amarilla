using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para conectar a bd

namespace TPWinForm_Aguirre_Amarillo
{
    internal class ArticuloBD
    {
        // ---- ATRIBUTOS ----
        Articulo artAux;
        public List<Articulo> lista = new List<Articulo>();
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        private decimal valorAux;

        // ---- METODOS ----
        public void Cargar()
        {       
                try
                {
                    conexion.ConnectionString = "server =. ; database= CATALOGO_DB; integrated security= true";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT A.Codigo, A.Nombre, C.Descripcion, A.Precio, M.Descripcion AS 'Marca' FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id";
                    cmd.Connection = conexion;

                    conexion.Open();
                    dr = cmd.ExecuteReader();

                // Cargamos los datos obtenidos con la query en nuestro objeto
                while (dr.Read())
                    {
                        artAux = new Articulo();
                        artAux._cod = (string)dr["Codigo"];
                        artAux._nombre = (string)dr["Nombre"];
                        artAux._descr = (string)dr["Descripcion"];
                        valorAux = (decimal)dr["Precio"];
                        artAux._precio = (double)valorAux;
                        lista.Add(artAux);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                { 
                    conexion.Close();
                }
        }
        public Articulo buscarXcodigo(string cod)
        {
            try
            {
                // Establecemos coneccion con la BD, y el tipo de query a realizar
                conexion.ConnectionString = "server = .; database = CATALOGO_DB; integrated security = true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"SELECT A.Codigo, A.Nombre, C.Descripcion, A.Precio, M.Descripcion AS 'Marca' FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id WHERE A.Codigo = '{cod}'";
                cmd.Connection = conexion;

                // Conectamos, mandamos la query y leemos los datos
                conexion.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                // Cargamos los datos obtenidos con la query en nuestro objeto
                artAux = new Articulo();
                artAux._cod = (string)dr["Codigo"];
                artAux._nombre = (string)dr["Nombre"];
                artAux._descr = (string)dr["Descripcion"];
                valorAux = (decimal)dr["Precio"];
                artAux._precio = (double)valorAux;
                return artAux;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            finally 
            {
                conexion.Close(); 
            }

            

        }
        // buscar por nombre
        public List<Articulo> buscarXnombre(string nom)
        {
            try
            {
                // Establecemos coneccion con la BD, y el tipo de query a realizar
                conexion.ConnectionString = "server = .; database = CATALOGO_DB; integrated security = true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"SELECT A.Codigo, A.Nombre, C.Descripcion, A.Precio, M.Descripcion AS 'Marca' FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id WHERE A.Nombre = '{nom}'";
                cmd.Connection = conexion;

                // Conectamos, mandamos la query y leemos los datos
                conexion.Open();
                dr = cmd.ExecuteReader();

                // Cargamos los datos obtenidos con la query en nuestro lista de objetos
                while (dr.Read())
                {
                    artAux = new Articulo();
                    artAux._cod = (string)dr["Codigo"];
                    artAux._nombre = (string)dr["Nombre"];
                    artAux._descr = (string)dr["Descripcion"];
                    valorAux = (decimal)dr["Precio"];
                    artAux._precio = (double)valorAux;
                    lista.Add(artAux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void Agregar(string cod, string nom, string desc)// faltan mas datos
        {
            try
            {
                conexion.ConnectionString = "server = .; database = CATALOGO_DB; integrated security = true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT INTO ARTICULOS VALUES('{cod}', '{nom}', '{desc}', 2, 1, 'nada', 1000000)"; // Falta seguir aca
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                conexion.Close();
            }
        }
    }
}
