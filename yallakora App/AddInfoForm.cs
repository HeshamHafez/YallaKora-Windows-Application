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
    public partial class AddInfoForm : Form
    {
        private string matchIndex;
        private string leagueIndex;
        public string matchId;
        private int team1_Id;
        private int team2_Id;
        private int selected_playerId;
        private int teamScored;
        public AddInfoForm()
        {
            InitializeComponent();
            fillLeagueCombo();
        }

        void fillLeagueCombo()
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
            leagueIndex = comboLeague.Text;
            sqlCommand1.CommandText = "select concat(t1.name,' vs ',t2.name),match_id from matches m  inner join teams t1 "
                                + "on m.team1_id = t1.team_id inner join teams t2 on m.team2_id = t2.team_id "
                                + "where t1.league_id = (select league_id from leagues where name ='" + leagueIndex + "' ) ";
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            comboMatch.Items.Clear();
            while (dReader.Read())
            {
                comboMatch.Items.Add(dReader[1] + " " + (string)dReader[0]);
            }

            dReader.Close();
            sqlConnection1.Close();
        }

        private void comboMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            matchIndex = comboMatch.Text;
            matchId = matchIndex.Substring(0, 1);
            sqlCommand1.CommandText = "select team1_id, team2_id from matches inner join teams on team1_id = team_id where match_id =" + matchId;
            SqlDataReader dReaderGetTeamID;
            sqlConnection1.Open();
            dReaderGetTeamID = sqlCommand1.ExecuteReader();
            if (dReaderGetTeamID.Read())
            {
                team1_Id = (int)dReaderGetTeamID[0];
                team2_Id = (int)dReaderGetTeamID[1];

            }
            dReaderGetTeamID.Close();

            sqlCommand1.CommandText = "select name from matches inner join teams on team1_id = team_id where match_id =" + matchId;
            SqlDataReader dReader;
            // sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                tbTeam1.Text = (string)dReader[0];
            }
            dReader.Close();


            sqlCommand1.CommandText = "select name from matches inner join teams on team2_id = team_id where match_id =" + matchId;
            SqlDataReader dReader1;
            dReader1 = sqlCommand1.ExecuteReader();
            while (dReader1.Read())
            {
                tbTeam2.Text = (string)dReader1[0];
            }
            dReader1.Close();


            sqlCommand1.CommandText = "select fullname,player_id from players p where p.team_id =(select team_id from teams where name ='" + tbTeam1.Text + "' )";
            SqlDataReader dReader2;
            dReader2 = sqlCommand1.ExecuteReader();
            comboTeam1.Items.Clear();
            while (dReader2.Read())
            {
                comboTeam1.Items.Add((int)dReader2[1] + " " + (string)dReader2[0]);
            }

            dReader2.Close();

            sqlCommand1.CommandText = "select fullname,player_id from players p where p.team_id =(select team_id from teams where name ='" + tbTeam2.Text + "' )";
            SqlDataReader dReader3;
            dReader3 = sqlCommand1.ExecuteReader();
            comboTeam2.Items.Clear();
            while (dReader3.Read())
            {
                comboTeam2.Items.Add((int)dReader3[1] + " " + (string)dReader3[0]);
            }

            dReader3.Close();
            sqlConnection1.Close();

        }

        private void comboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_playerId = int.Parse(comboTeam1.Text.Substring(0, 1));
            teamScored = 1;
            comboTeam2.Text = "";
        }

        private void comboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_playerId = int.Parse(comboTeam2.Text.Substring(0, 1));
            teamScored = 2;
            comboTeam1.Text = "";
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            if (teamScored == 1)
            {
                if (!String.IsNullOrEmpty(tbGoals.Text))
                {
                    for (int i = 0; i < int.Parse(tbGoals.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into goals (match_id, player_id, team_id, team_scored_against_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team1_Id + "', '" + team2_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
                if (!String.IsNullOrEmpty(tbYellowCards.Text))
                {
                    for (int i = 0; i < int.Parse(tbYellowCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into yellow_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team1_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
                if (!String.IsNullOrEmpty(tbRedCards.Text))
                {
                    for (int i = 0; i < int.Parse(tbRedCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into red_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team1_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
            }
            else if (teamScored == 2)
            {
                if (!String.IsNullOrEmpty(tbGoals.Text))
                {
                    for (int i = 0; i < int.Parse(tbGoals.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into goals (match_id, player_id, team_id, team_scored_against_id) values(' " + matchId + " ', '"
                        + selected_playerId + "', '" + team2_Id + "', '" + team1_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
                if (!String.IsNullOrEmpty(tbYellowCards.Text))
                {
                    for (int i = 0; i < int.Parse(tbYellowCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into yellow_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team2_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
                if (!String.IsNullOrEmpty(tbRedCards.Text))
                {
                    for (int i = 0; i < int.Parse(tbRedCards.Text); i++)
                    {
                        sqlCommand1.CommandText = "insert into red_cards (match_id, player_id, team_id) values(' " + matchId + " ', '"
                            + selected_playerId + "', '" + team2_Id + "')";
                        sqlCommand1.ExecuteNonQuery();
                    }
                }
            }
            sqlConnection1.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            sqlCommand1.CommandText = "update  matches set team1_score = " + tbTeam1Score.Text + "" +
                ", team2_score = " + tbTeam2Score.Text + ", status = 'finished' where match_id=" + matchId;
            sqlCommand1.ExecuteNonQuery();

            if (int.Parse(tbTeam1Score.Text) > int.Parse(tbTeam2Score.Text))
            {
                sqlCommand1.CommandText = "update teams set points +=3, wins +=1, goals_for += " + tbTeam1Score.Text + "," +
                    " goals_against += " + tbTeam2Score.Text + " where team_id =" + team1_Id;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand1.CommandText = "update teams set loss +=1, goals_for += " + tbTeam2Score.Text + "," +
                    " goals_against += " + tbTeam1Score.Text + " where team_id =" + team2_Id;
                sqlCommand1.ExecuteNonQuery();
            }
            else if (int.Parse(tbTeam1Score.Text) < int.Parse(tbTeam2Score.Text))
            {
                sqlCommand1.CommandText = "update teams set points +=3, wins +=1, goals_for += " + tbTeam2Score.Text + "," +
                    " goals_against += " + tbTeam1Score.Text + " where team_id =" + team2_Id;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand1.CommandText = "update teams set loss +=1, goals_for += " + tbTeam1Score.Text + "," +
                    " goals_against += " + tbTeam2Score.Text + " where team_id =" + team1_Id;
                sqlCommand1.ExecuteNonQuery();
            }
            else if (int.Parse(tbTeam1Score.Text) == int.Parse(tbTeam2Score.Text))
            {
                sqlCommand1.CommandText = "update teams set points +=1, draws +=1, goals_for += " + tbTeam2Score.Text + "," +
                    " goals_against += " + tbTeam1Score.Text + " where team_id =" + team2_Id;
                sqlCommand1.ExecuteNonQuery();
                sqlCommand1.CommandText = "update teams set points +=1, draws +=1, goals_for += " + tbTeam1Score.Text + "," +
                    " goals_against += " + tbTeam2Score.Text + " where team_id =" + team1_Id;
                sqlCommand1.ExecuteNonQuery();
            }
            sqlConnection1.Close();
        }
    }
}
