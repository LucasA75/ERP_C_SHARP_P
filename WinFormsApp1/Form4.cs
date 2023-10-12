using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {


        DataSet ds;
        SqlConnection sqlConnection;
        SqlDataReader registro;
        SqlCommand command;
        public int admin;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut, nombre, direccion;
            int telefono, valorHora, valorExtra;
            rut = textBox1.Text;
            nombre = textBox2.Text;
            direccion = textBox3.Text;
            if (!int.TryParse(textBox4.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser un número entero.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out valorHora))
            {
                MessageBox.Show("El valor por hora debe ser un número entero.");
                return;
            }

            if (!int.TryParse(textBox6.Text, out valorExtra))
            {
                MessageBox.Show("El valor extra debe ser un número entero.");
                return;
            }

            string query = "INSERT INTO datosTrabajadores (direccion, nombre, rut, telefono, ValorExtra, valorHora) " +
                          "VALUES (@direccion, @nombre, @rut, @telefono, @valorExtra, @valorHora)";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@rut", rut);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@valorExtra", valorExtra);
                command.Parameters.AddWithValue("@valorHora", valorHora);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserción exitosa.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el registro.");
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection("server=lucasa; database=dbpruebaene;integrated security = true");
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.admin = admin;
            form3.ShowDialog();
        }
    }
}
