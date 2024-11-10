using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto
{
    internal class Contactos
    {
        private int id;
        private string nombre;
        private string correo;
        private string fono;
        private string tipo;

        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-1ALE17VJ\\SQLEXPRESS;Initial Catalog=BD_Contactos;Integrated Security=True;TrustServerCertificate=True");

        public Contactos(string nombre, string correo, string fono, string tipo)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.fono = fono;
            this.tipo = tipo;
        }
        public int AgregarContacto()
        {

            cn.Open();
            SqlCommand consulta = new SqlCommand("INSERT INTO tb_contactos Values(@nombre, @correo, @fono, @tipo)", cn);
            consulta.Parameters.AddWithValue("nombre", nombre);
            consulta.Parameters.AddWithValue("correo", correo);
            consulta.Parameters.AddWithValue("fono", fono);
            consulta.Parameters.AddWithValue("tipo", tipo);

            int filasAfectadas = consulta.ExecuteNonQuery();

            cn.Close();

            return filasAfectadas;
        }
    }
}
