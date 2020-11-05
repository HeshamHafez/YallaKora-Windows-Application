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
    public partial class AddTeamForm : Form
    {
        private string index;
        public AddTeamForm()
        {
            InitializeComponent();
            fillCombo();
        }

        void fillCombo()
        {
            sqlCommand1.CommandText = "select * from leagues";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboLeague.Items.Clear();
            while (dReader.Read())
            {
                comboLeague.Items.Add((string)dReader[1]);

            }
            dReader.Close();
            sqlConnection1.Close();
        }


        private void comboLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboLeague.Text;
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            sqlCommand1.CommandText = "insert into teams (name, league_id, coach) values('" + textBoxTeam.Text + "', " +
            "(select league_id from leagues where name='" + index + "'), '" + textBoxCoach.Text + "')";
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}
