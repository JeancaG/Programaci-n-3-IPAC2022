using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class UsuarioAD
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Programacion; Uid=root; Pwd=Ranson_007;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM Usuario WHERE Codigo = @Codigo AND Clave = @Clave;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Rol = reader[2].ToString();
                    user.Clave = reader[3].ToString();
                    user.EstaActivo = Convert.ToBoolean(reader[4]);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return user;
        }

        public DataTable ListarUsuarios()
        {
           DataTable listarUsuariosDT = new DataTable();
            try
            {
                string sql = "SELECT * FROM Usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listarUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
            }
            return listarUsuariosDT;
        }

        public bool InsertarUsuario()
        {
            throw new NotImplementedException();
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            bool inserto = false;

            try
            {
                string sql = "INSERT INTO Usuario VALUES (@Codigo, @Nombre, @Rol, @Clave, @EstaActivo);";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", usuario.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@EstaActivo", usuario.EstaActivo);

                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();
            }
            catch(Exception)
            {

            }
            return inserto;
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            bool modifico = false;

            try
            {
                string sql = "UPDATE FROM Usuario SET Codigo = (@Codigo, Nombre = @Nombre, Rol = @Rol, Clave = @Clave, EstaActivo = @EstaActivo WHERE Codigo = @Codigo);";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", usuario.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@EstaActivo", usuario.EstaActivo);

                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return modifico;
        }
        
        public bool EliminarUsuario(string codigo)
        {
            bool elimino = false;

            try
            {
                string sql = "DELETE FROM Usuario WHERE Codigo = @Codigo;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);


                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return elimino;
        }
    }
}
