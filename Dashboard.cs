using System.Data;
using System.Data.SQLite;

namespace UtopiaApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\db\UtopiaDB.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("Select * From Sales", con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\db\UtopiaDB.db");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Sales VALUES(NULL,"+textBoxCash.Text +","+textBoxBank.Text+","+textBoxBkash.Text+","+textBoxDue.Text+",1,"+int.Parse(textBoxYear.Text)+",'"+(DateTime.Now).ToString()+"');", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ShowButton_Click(sender,e);
        }
    }
}
