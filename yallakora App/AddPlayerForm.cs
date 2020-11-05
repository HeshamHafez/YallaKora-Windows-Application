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

namespace yallakora_App
{
    public partial class AddPlayerForm : Form
    {
        private string index;
        public AddPlayerForm()
        {
            InitializeComponent();
            fillCombo();
        }
        void fillCombo()
        {
            sqlCommand1.CommandText = "select * from teams";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboTeam.Items.Clear();
            while (dReader.Read())
            {
                comboTeam.Items.Add((string)dReader[1]);

            }

            dReader.Close();
            sqlConnection1.Close();
        }

        private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboTeam.Text;

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "insert into players (fullname, team_id, age, number) values('" + textBoxPlayer.Text + "'," +
            " (select team_id from teams where name='" + index + "'), " + textBoxAge.Text + ", " + textBoxNum.Text + ")";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}
