using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yallakora_App
{
    public partial class AddLeagueForm : Form
    {
        public AddLeagueForm()
        {
            InitializeComponent();
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "INSERT INTO leagues (name) VALUES('" + textBoxLeague.Text + "')";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            textBoxLeague.Text = "";
        }

    }
}
