using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LeagueOfLegends
{
    public partial class AbilityPreview : Form
    {
        SqlConnection connection;
        string connectionString;

        public AbilityPreview()
        {
            InitializeComponent();

            //Initialize Connection String when Form Object is created.
            connectionString = ConfigurationManager.ConnectionStrings["LeagueOfLegends.Properties.Settings.LeagueOfLegendsConnectionString"].ConnectionString;

        }
        private void AbilityPreview_Load(object sender, EventArgs e)
        {
            PopulateChampions();
            PopulateAbilities();

        }

        private void PopulateChampions()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Champion", connection))
            {
                DataTable championTable = new DataTable();
                adapter.Fill(championTable);

                lstChampions.DisplayMember = "Name";
                lstChampions.ValueMember = "Id";
                lstChampions.DataSource = championTable;
            }



            
        }

        private void PopulateAbilities()
        {
            string sqlQuery = "SELECT a.name, a.description FROM Abilities a " + "INNER JOIN ChampionAbilities b ON a.Id = b.AbilityId " + "WHERE b.ChampionID = @ChampionId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection)) 
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ChampionId", lstChampions.SelectedValue);

                DataTable abilityTable = new DataTable();
                adapter.Fill(abilityTable);

                lstAbilities.MultiColumn = true;
                lstAbilities.DisplayMember = "Name";
                lstAbilities.ValueMember = "Id";
                lstAbilities.DataSource = abilityTable;
            }




        }

        private void lstChampions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAbilities();
        }

        private void lstAbilities_Format(object sender, ListControlConvertEventArgs e)
        {
        }
    }
}
