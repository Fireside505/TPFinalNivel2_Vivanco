using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;
using Dominio;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;

namespace Datos
{
    public class ArticulosDatos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl Imagen, A.Precio, M.Id, C.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = a.IdCategoria";
                    comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.descripcion = (string)lector["Marca"];
                    aux.Marca.id = (int)lector["Id"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.descripcion = (string)lector["Categoria"];
                    aux.Categoria.id = (int)lector["Id"];
                    if (!(lector["Imagen"] is DBNull))
                        aux.Imagen = (string)lector["Imagen"];
                    aux.Precio = (decimal)lector["Precio"];
                    

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
           
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values ('" + nuevo.CodigoArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, @Imagen," + nuevo.Precio + ")");
                datos.setearParametro("@idMarca", nuevo.Marca.id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.id);
                datos.setearParametro("@Imagen", nuevo.Imagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS set Codigo= @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca,  IdCategoria = @idCategoria, ImagenUrl = @imagenURL, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificar.CodigoArticulo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@idMarca", modificar.Marca.id);
                datos.setearParametro("@idCategoria", modificar.Categoria.id);
                datos.setearParametro("@imagenURL", modificar.Imagen);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            { 
                datos.cerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from ARTICULOS where Id = @id ");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtroAvanzado)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl Imagen, A.Precio, M.id, C.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = a.IdCategoria and ";

                if (campo == "Código")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Codigo like '" + filtroAvanzado + " % ' ";
                            break;
                        case "Termina con":
                            consulta += "A.Codigo like '%" + filtroAvanzado + " ' ";
                            break;
                        default:
                            consulta += "A.Codigo like ' % " + filtroAvanzado + " % ' ";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Nombre like '" + filtroAvanzado + " % ' ";
                            break;
                        case "Termina con":
                            consulta += "A.Nombre like '%" + filtroAvanzado + " ' ";
                            break;
                        default:
                            consulta += "A.Nombre like ' % " + filtroAvanzado + " % ' ";
                            break;

                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtroAvanzado + " % ' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtroAvanzado + " ' ";
                            break;
                        default:
                            consulta += "A.Descripcion like ' % " + filtroAvanzado + " % ' ";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.id = (int)datos.Lector["Id"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagen"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
