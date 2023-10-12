using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        DataSet ds;
        SqlConnection sqlConnection;
        SqlDataReader registro;
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
            Form2 form = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void entryBtn_Click(object sender, EventArgs e)
        {
            string userName = textBox2.Text;
            string password = textBox1.Text;
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT username, password, admin FROM usuarios WHERE username = @username AND password = @password;", sqlConnection))
                {
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader registro = command.ExecuteReader())
                    {
                        if (registro.Read())
                        {
                            int admin = (int)Convert.ToUInt32(registro["admin"]);
                            MessageBox.Show("Entrada exitosa.");
                            this.Hide();

                            if (admin == 1)
                            {
                                Form4 form = new Form4();
                                form.admin = admin;
                                form.Show();
                            }
                            else
                            {

                                Form2 form = new Form2();
                                form.data = userName;
                                form.Show();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalido username o password.");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}