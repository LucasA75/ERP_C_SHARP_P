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
    public partial class Form2 : Form
    {

        SqlConnection sqlConnection;

        int valorHora;
        int valorHoraExtra;
        string rut;
        decimal descuentoAFP;
        decimal descuentoSalud;
        int sueldoBruto;
        int sueldoLiquido;

        public string data;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            namePerson.Text = $"Bienvenido {data}";
            rutCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            afpCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            saludCombobox.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                sqlConnection = new SqlConnection("server=lucasa; database=dbpruebaene;integrated security = true");
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.rellenarComboBox(rutCombobox, "rut", "datosTrabajadores");
            this.rellenarComboBox(saludCombobox, "nombre", "saludTable");
            this.rellenarComboBox(afpCombobox, "nombre", "afpTable");

        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 formData = new Form3();
            formData.ShowDialog();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            if (verificacionCamposVacios())
            {
                if (!int.TryParse(textBox1.Text, out int horasTrabajadas))
                {
                    MessageBox.Show(" Horas trabajadas debe ser un número entero.");
                    return;
                }
                int horasExtraTrabajadas;
                if (textBox2.Text == null || textBox2.Text == "")
                {
                    horasExtraTrabajadas = 0;
                }
                else
                {
                    if (!int.TryParse(textBox2.Text, out horasExtraTrabajadas))
                    {
                        MessageBox.Show(" Horas trabajadas debe ser un número entero.");
                        return;
                    }
                }

                sueldoBruto = ((horasTrabajadas * valorHora) + (horasExtraTrabajadas * valorHoraExtra));
                sueldoBrutoBox.Text = $"${sueldoBruto.ToString()}";

                sueldoLiquido = (int)Math.Round((sueldoBruto - ((sueldoBruto * descuentoAFP) + (sueldoBruto * descuentoSalud))));
                sueldoLiquidoBox.Text = $"${sueldoLiquido.ToString()}";

            }
            else
            {
                MessageBox.Show("Porfavor rellena los campos faltantes");
            }

        }


        private bool verificacionCamposVacios()
        {
            if (textBox1.Text.Length > 0 && rutCombobox.SelectedItem != null && afpCombobox.SelectedItem != null && saludCombobox.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rutCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rutCombobox.SelectedItem != null)
            {
                string selectedValue = rutCombobox.SelectedItem.ToString();
                rut = selectedValue;
            }
            valorHoras(rut);
        }

        private void valorHoras(string rut)
        {
            using (SqlCommand command = new SqlCommand($"select valorHora, valorExtra from datosTrabajadores where rut = '{rut}'", sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    valorHora = (int)reader["valorHora"];
                    valorHoraExtra = (int)reader["valorExtra"];
                }
                reader.Close();
            }
        }

        private void afpCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (afpCombobox.SelectedItem != null)
            {
                string selectedValue = afpCombobox.SelectedItem.ToString();
                valorAFP(selectedValue);
            }
        }

        private void valorAFP(string nombreAFP)
        {
            using (SqlCommand command = new SqlCommand($"select descuento from afpTable where nombre = '{nombreAFP}'", sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    descuentoAFP = (decimal)reader["descuento"];
                }
                reader.Close();
            }
        }

        private void saludCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saludCombobox.SelectedItem != null)
            {
                string selectedValue = saludCombobox.SelectedItem.ToString();
                valorSalud(selectedValue);
            }
        }

        private void valorSalud(string nombreSalud)
        {
            using (SqlCommand command = new SqlCommand($"select descuento from saludTable where nombre = '{nombreSalud}'", sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    descuentoSalud = (decimal)reader["descuento"];
                    MessageBox.Show(descuentoSalud.ToString());
                }
                reader.Close();
            }
        }

        private int idSaludSQL(string nombreSalud)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"select id_salud from saludTable where nombre = '{nombreSalud}'", sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id_salud = (int)reader["id_salud"];
                        reader.Close();
                        return id_salud;
                    }
                    else
                    {
                        reader.Close();
                        return 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se encontro ningun nombre asociado", e);
            }
        }

        private int idAFPSQL(string nombreAfp)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"select id_afp from afpTable where nombre = '{nombreAfp}'", sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id_afp = (int)reader["id_afp"];
                        reader.Close();
                        return id_afp;
                    }
                    else
                    {
                        reader.Close();
                        return 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se encontro ningun nombre asociado", e);
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand($"Insert into sueldoTrabajador(rutTrabajador,sueldoBruto,sueldoLiquido,afp,salud)" +
                $"values('{rut}',{sueldoBruto},{sueldoLiquido},{idAFPSQL(afpCombobox.SelectedItem.ToString()!)},{idSaludSQL(saludCombobox.SelectedItem.ToString()!)});", sqlConnection))
            {
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    MessageBox.Show("Guardado Exitosamente");
                }
            }
        }

        // Borrar todo el contenido de la pantalla
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            sueldoBrutoBox.Text = string.Empty;
            sueldoLiquidoBox.Text = string.Empty;
            afpCombobox.Text = null;
            saludCombobox.Text = null;
            rutCombobox.Text = null;
            MessageBox.Show("Puedes volver a ingresar datos", "Borrado Completo");
        }
    }
}
