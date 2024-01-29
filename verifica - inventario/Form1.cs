using MySql.Data.MySqlClient;
namespace verifica___inventario
{
    public partial class Form1 : Form
    {
        string conn = "server=127.0.0.1;" + "database=inventario;" + "uid=augusto;" + "pwd=augusto";


        public Form1()
        {
            InitializeComponent();
            //TestConnessione();
            PopolaTabella("");
        }
        public void PopolaTabella(string q)
        {
            dataGridView1.Rows.Clear();
            MySqlConnection connessione = new MySqlConnection(conn);
            try
            {
                string search = textBoxFilter.Text;

                string Filter = $"SELECT * FROM articoli WHERE CodiceFarnell LIKE '%{q}%' " +
                    $"OR CodiceProduttore LIKE '%{q}%' OR Produttore LIKE '%{q}%' OR Prezzo LIKE '%{q}%' ";
                    

                
                connessione.Open();
                string query = "SELECT * FROM articoli";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr.GetInt32("CodiceFarnell").ToString(),
                        dr.GetString("CodiceProduttore"),
                        dr.GetString("Produttore"),
                        dr.GetDecimal("PrezzoUnitario").ToString()
                    );
                }

                connessione.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.AutoResizeColumns();
        }

        public void TestConnessione()
        {
            MySqlConnection connessione = new MySqlConnection(conn);
            try
            {
                connessione.Open();
                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Form2 formModifica = new Form2();

            formModifica.ShowDialog();

            // aggiorno la tabella appena si chiude
            PopolaTabella("");
        }
        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            PopolaTabella(textBoxFilter.Text);
        }
    }
}