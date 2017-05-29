using System;
using System.Data;
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
            SqlConnection cn = new SqlConnection(connectionString);

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
            listView1.Items.Clear();

            string sqlQuery = "SELECT * FROM Abilities a " + "INNER JOIN ChampionAbilities b ON a.Id = b.AbilityId " + "WHERE b.ChampionID = @ChampionId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ChampionId", lstChampions.SelectedValue);

                DataTable abilityTable = new DataTable();
                adapter.Fill(abilityTable);

                foreach(DataRow dr in abilityTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Name"].ToString());
                    item.SubItems.Add(dr["Description"].ToString());

                    listView1.Items.Add(item);
                }
            }
        }


        private void PopulateStats()
        {
            listView2.Items.Clear();

            string sqlQuery = "SELECT [Primary Role], [Health], [Health Regen], [Attack Damage], [Armor], [Attack Speed], [Magic Resist], [Movement Speed] FROM Champion WHERE Id = @ChampionId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ChampionId", lstChampions.SelectedValue);

                DataTable championTable = new DataTable();
                adapter.Fill(championTable);

                foreach (DataRow dr in championTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Primary Role"].ToString());
                    item.SubItems.Add(dr["Health"].ToString());
                    item.SubItems.Add(dr["Health Regen"].ToString());
                    item.SubItems.Add(dr["Attack Damage"].ToString());
                    item.SubItems.Add(dr["Armor"].ToString());
                    item.SubItems.Add(dr["Attack Speed"].ToString());
                    item.SubItems.Add(dr["Magic Resist"].ToString());
                    item.SubItems.Add(dr["Movement Speed"].ToString());


                    listView2.Items.Add(item);
                }
            }


        }

        private void lstChampions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAbilities();
            PopulateStats();
        }
    }
}
