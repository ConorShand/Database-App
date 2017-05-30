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

            PopulateAll();

        }

        private void PopulateChampions()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Champion", connection))
            {
                DataTable championTable = new DataTable();
                adapter.Fill(championTable);

                lstChampions.DisplayMember = "Name";
                lstChampionAbility.DisplayMember = "Name";

                lstChampions.ValueMember = "Id";
                lstChampionAbility.ValueMember = "Id";

                lstChampions.DataSource = championTable;
                lstChampionAbility.DataSource = championTable;

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


        private void PopulateAllAbilities()
        {
            listView1.Items.Clear();

            string sqlQuery = "SELECT * FROM Abilities";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable abilityTable = new DataTable();
                adapter.Fill(abilityTable);

                lstAbilities.DisplayMember = "Name";
                lstAbilities.ValueMember = "Id";
                lstAbilities.DataSource = abilityTable;


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

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {

            string sqlQuery = "INSERT INTO Champion VALUES (@ChampionName, @Role, @Health, @HealthRegen, @AttackDamage, @Armor, @AttackSpeed, @MagicResist, @MoveSpeed)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ChampionName", txtAddName.Text);
                command.Parameters.AddWithValue("@Role", txtAddRole.Text);
                command.Parameters.AddWithValue("@Health", txtAddHealth.Text);
                command.Parameters.AddWithValue("@HealthRegen", txtAddHealthRegen.Text);
                command.Parameters.AddWithValue("@AttackDamage", txtAddAttackDamage.Text);
                command.Parameters.AddWithValue("@Armor", txtAddArmor.Text);
                command.Parameters.AddWithValue("@AttackSpeed", txtAddAttackSpeed.Text);
                command.Parameters.AddWithValue("@MagicResist", txtAddMagicResist.Text);
                command.Parameters.AddWithValue("@MoveSpeed", txtAddMoveSpeed.Text);

                command.ExecuteNonQuery();

                PopulateAll();
                clearTxt();
            }

        }


        private void clearTxt()
        {
            txtAddName.Clear();
            txtAddRole.Clear();
            txtAddHealth.Clear();
            txtAddHealthRegen.Clear();
            txtAddAttackDamage.Clear();
            txtAddArmor.Clear();
            txtAddAttackSpeed.Clear();
            txtAddMagicResist.Clear();
            txtAddMoveSpeed.Clear();
            txtAddAbility.Clear();
            txtAddDescription.Clear();


        }

        private void btnAddAbility_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO Abilities VALUES (@Name, @Description)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Name", txtAddAbility.Text);
                command.Parameters.AddWithValue("@Description", txtAddDescription.Text);

                command.ExecuteNonQuery();

                PopulateAll();
                clearTxt();
            }
        }

        private void btnAssignAbility_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO ChampionAbilities VALUES (@ChampionID, @AbilityID)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ChampionID", lstChampionAbility.SelectedValue);
                command.Parameters.AddWithValue("@AbilityID", lstAbilities.SelectedValue);
               
                command.ExecuteNonQuery();

                PopulateAll();
                clearTxt();
            }
        }

        private void PopulateAll()
        {
            PopulateChampions();
            PopulateAbilities();
            PopulateStats();
            PopulateAllAbilities();
        }
    }
}
