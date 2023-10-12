using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {

        DataSet ds;
        SqlConnection sqlConnection;
        SqlDataReader registro;
        SqlCommand command;
        public int admin;


        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (admin == 1)
            {
                this.Close();
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                this.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.SelectedIndex = 0;
                sqlConnection = new SqlConnection("server=lucasa; database=dbpruebaene; integrated security = true");
                sqlConnection.Open();

                if (admin != 1)
                {
                    button1.Hide();
                    button2.Hide();
                }

                DataTable dt = new DataTable();

                string query = "WITH UltimoSueldo AS (\r\n SELECT rutTrabajador, MAX(id_sueldo) AS id_sueldo\r\n    FROM sueldoTrabajador\r\n  " +
                    "  GROUP BY rutTrabajador\r\n)\r\nSELECT us.rutTrabajador as RUT,dt.nombre,dt.direccion, st.sueldoLiquido as 'Sueldo Liquido'\r\n" +
                    "FROM UltimoSueldo us\r\nINNER JOIN sueldoTrabajador st ON us.id_sueldo = st.id_sueldo\r\ninner join datosTrabajadores dt ON us.rutTrabajador = dt.rut";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;
                }

                this.rellenarComboBox(comboBox1, "rut", "datosTrabajadores");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void rellenarComboBox(ComboBox combobox, string columna, string tabla)
        {
            using (SqlCommand command = new SqlCommand($"SELECT {columna} from {tabla};", sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    combobox.Items.Add(reader[columna].ToString());
                }
                reader.Close();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string rutSelected = comboBox1.SelectedItem.ToString();

                string query = "WITH UltimoSueldo AS (\r\n SELECT rutTrabajador, MAX(id_sueldo) AS id_sueldo\r\n    FROM sueldoTrabajador\r\n  " +
                    "  GROUP BY rutTrabajador\r\n)\r\nSELECT us.rutTrabajador as RUT,dt.nombre,dt.direccion, st.sueldoLiquido as 'Sueldo Liquido'\r\n" +
                    "FROM UltimoSueldo us INNER JOIN sueldoTrabajador st ON us.id_sueldo = st.id_sueldo\r\ninner join datosTrabajadores dt ON us.rutTrabajador = dt.rut";

                if (rutSelected != "Todos")
                {
                    query = query + $" where us.rutTrabajador = '{rutSelected}';";
                }

                DataTable dt = new DataTable();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    reader.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Habilita la edición de la celda seleccionada
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            }
        }

        //Boton Modificar
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string rut = Convert.ToString(row.Cells["RUT"].Value);
                string nombre = Convert.ToString(row.Cells["Nombre"].Value);
                string direccion = Convert.ToString(row.Cells["direccion"].Value);
                string query = $"UPDATE datosTrabajadores SET nombre = '{nombre}', direccion = '{direccion}' where rut = '{rut}'";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))

                {
                    command.ExecuteNonQuery();     
                }
            }

            // Deshabilita la edición después de hacer la modificación
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
