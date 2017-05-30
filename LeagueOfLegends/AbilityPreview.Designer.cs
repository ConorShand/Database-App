namespace LeagueOfLegends
{
    partial class AbilityPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leagueOfLegendsDataSet = new LeagueOfLegends.LeagueOfLegendsDataSet();
            this.lblChampions = new System.Windows.Forms.Label();
            this.lstChampions = new System.Windows.Forms.ListBox();
            this.lblAbilities = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAssignAbility = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lstAbilities = new System.Windows.Forms.ListBox();
            this.btnAddAbility = new System.Windows.Forms.Button();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddAbility = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstChampionAbility = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddToDatabase = new System.Windows.Forms.Button();
            this.txtAddMoveSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddMagicResist = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddAttackSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddArmor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddAttackDamage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddHealthRegen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddHealth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.leagueOfLegendsDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // leagueOfLegendsDataSet
            // 
            this.leagueOfLegendsDataSet.DataSetName = "LeagueOfLegendsDataSet";
            this.leagueOfLegendsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblChampions
            // 
            this.lblChampions.AutoSize = true;
            this.lblChampions.Location = new System.Drawing.Point(54, 38);
            this.lblChampions.Name = "lblChampions";
            this.lblChampions.Size = new System.Drawing.Size(59, 13);
            this.lblChampions.TabIndex = 0;
            this.lblChampions.Text = "Champions";
            // 
            // lstChampions
            // 
            this.lstChampions.FormattingEnabled = true;
            this.lstChampions.Location = new System.Drawing.Point(21, 65);
            this.lstChampions.Name = "lstChampions";
            this.lstChampions.Size = new System.Drawing.Size(134, 147);
            this.lstChampions.TabIndex = 1;
            this.lstChampions.SelectedIndexChanged += new System.EventHandler(this.lstChampions_SelectedIndexChanged);
            // 
            // lblAbilities
            // 
            this.lblAbilities.AutoSize = true;
            this.lblAbilities.Location = new System.Drawing.Point(250, 38);
            this.lblAbilities.Name = "lblAbilities";
            this.lblAbilities.Size = new System.Drawing.Size(42, 13);
            this.lblAbilities.TabIndex = 2;
            this.lblAbilities.Text = "Abilities";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstName,
            this.Description});
            this.listView1.Location = new System.Drawing.Point(161, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1018, 146);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lstName
            // 
            this.lstName.Text = "Name";
            this.lstName.Width = 149;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 2498;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1181, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "View Champions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 336);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblChampions);
            this.tabPage1.Controls.Add(this.lstChampions);
            this.tabPage1.Controls.Add(this.lblAbilities);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1187, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Champions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Location = new System.Drawing.Point(21, 230);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1158, 68);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Role";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Health";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Health Regen";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Attack Damage";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Armor";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Attack Speed";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Magic Resist";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Movement Speed";
            this.columnHeader8.Width = 115;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1187, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Champion/Ability";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAssignAbility
            // 
            this.btnAssignAbility.Location = new System.Drawing.Point(436, 72);
            this.btnAssignAbility.Name = "btnAssignAbility";
            this.btnAssignAbility.Size = new System.Drawing.Size(121, 65);
            this.btnAssignAbility.TabIndex = 30;
            this.btnAssignAbility.Text = "Assign Ability to Champion";
            this.btnAssignAbility.UseVisualStyleBackColor = true;
            this.btnAssignAbility.Click += new System.EventHandler(this.btnAssignAbility_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "All Abilities";
            // 
            // lstAbilities
            // 
            this.lstAbilities.FormattingEnabled = true;
            this.lstAbilities.Location = new System.Drawing.Point(235, 43);
            this.lstAbilities.Name = "lstAbilities";
            this.lstAbilities.Size = new System.Drawing.Size(196, 147);
            this.lstAbilities.TabIndex = 28;
            // 
            // btnAddAbility
            // 
            this.btnAddAbility.Location = new System.Drawing.Point(51, 91);
            this.btnAddAbility.Name = "btnAddAbility";
            this.btnAddAbility.Size = new System.Drawing.Size(102, 58);
            this.btnAddAbility.TabIndex = 27;
            this.btnAddAbility.Text = "Add Ability";
            this.btnAddAbility.UseVisualStyleBackColor = true;
            this.btnAddAbility.Click += new System.EventHandler(this.btnAddAbility_Click);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(187, 50);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(244, 119);
            this.txtAddDescription.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Description";
            // 
            // txtAddAbility
            // 
            this.txtAddAbility.Location = new System.Drawing.Point(37, 50);
            this.txtAddAbility.Name = "txtAddAbility";
            this.txtAddAbility.Size = new System.Drawing.Size(123, 20);
            this.txtAddAbility.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ability Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-113, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Select Champion";
            // 
            // lstChampionAbility
            // 
            this.lstChampionAbility.FormattingEnabled = true;
            this.lstChampionAbility.Location = new System.Drawing.Point(20, 43);
            this.lstChampionAbility.Name = "lstChampionAbility";
            this.lstChampionAbility.Size = new System.Drawing.Size(202, 147);
            this.lstChampionAbility.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Add Ability";
            // 
            // btnAddToDatabase
            // 
            this.btnAddToDatabase.Location = new System.Drawing.Point(1070, 31);
            this.btnAddToDatabase.Name = "btnAddToDatabase";
            this.btnAddToDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDatabase.TabIndex = 19;
            this.btnAddToDatabase.Text = "Add";
            this.btnAddToDatabase.UseVisualStyleBackColor = true;
            this.btnAddToDatabase.Click += new System.EventHandler(this.btnAddToDatabase_Click);
            // 
            // txtAddMoveSpeed
            // 
            this.txtAddMoveSpeed.Location = new System.Drawing.Point(920, 34);
            this.txtAddMoveSpeed.Name = "txtAddMoveSpeed";
            this.txtAddMoveSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtAddMoveSpeed.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(935, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Move Speed";
            // 
            // txtAddMagicResist
            // 
            this.txtAddMagicResist.Location = new System.Drawing.Point(805, 34);
            this.txtAddMagicResist.Name = "txtAddMagicResist";
            this.txtAddMagicResist.Size = new System.Drawing.Size(100, 20);
            this.txtAddMagicResist.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(820, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Magic Resist";
            // 
            // txtAddAttackSpeed
            // 
            this.txtAddAttackSpeed.Location = new System.Drawing.Point(691, 34);
            this.txtAddAttackSpeed.Name = "txtAddAttackSpeed";
            this.txtAddAttackSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtAddAttackSpeed.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(706, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Attack Speed";
            // 
            // txtAddArmor
            // 
            this.txtAddArmor.Location = new System.Drawing.Point(579, 34);
            this.txtAddArmor.Name = "txtAddArmor";
            this.txtAddArmor.Size = new System.Drawing.Size(100, 20);
            this.txtAddArmor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Armor";
            // 
            // txtAddAttackDamage
            // 
            this.txtAddAttackDamage.Location = new System.Drawing.Point(464, 34);
            this.txtAddAttackDamage.Name = "txtAddAttackDamage";
            this.txtAddAttackDamage.Size = new System.Drawing.Size(100, 20);
            this.txtAddAttackDamage.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Attack Damage";
            // 
            // txtAddHealthRegen
            // 
            this.txtAddHealthRegen.Location = new System.Drawing.Point(350, 34);
            this.txtAddHealthRegen.Name = "txtAddHealthRegen";
            this.txtAddHealthRegen.Size = new System.Drawing.Size(100, 20);
            this.txtAddHealthRegen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Health Regen";
            // 
            // txtAddHealth
            // 
            this.txtAddHealth.Location = new System.Drawing.Point(234, 34);
            this.txtAddHealth.Name = "txtAddHealth";
            this.txtAddHealth.Size = new System.Drawing.Size(100, 20);
            this.txtAddHealth.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Health";
            // 
            // txtAddRole
            // 
            this.txtAddRole.Location = new System.Drawing.Point(119, 34);
            this.txtAddRole.Name = "txtAddRole";
            this.txtAddRole.Size = new System.Drawing.Size(100, 20);
            this.txtAddRole.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(5, 34);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1181, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Champions and Abilities";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddDescription);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAddAbility);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnAddAbility);
            this.groupBox1.Location = new System.Drawing.Point(22, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 198);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ability";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lstAbilities);
            this.groupBox2.Controls.Add(this.lstChampionAbility);
            this.groupBox2.Controls.Add(this.btnAssignAbility);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(582, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 196);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Ability";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(80, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "All Champions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddToDatabase);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAddName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAddMoveSpeed);
            this.groupBox3.Controls.Add(this.txtAddRole);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAddMagicResist);
            this.groupBox3.Controls.Add(this.txtAddHealth);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAddAttackSpeed);
            this.groupBox3.Controls.Add(this.txtAddHealthRegen);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAddArmor);
            this.groupBox3.Controls.Add(this.txtAddAttackDamage);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1151, 73);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Champion";
            // 
            // AbilityPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "AbilityPreview";
            this.Text = "Ability Preview";
            this.Load += new System.EventHandler(this.AbilityPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leagueOfLegendsDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LeagueOfLegendsDataSet leagueOfLegendsDataSet;
        private System.Windows.Forms.Label lblChampions;
        private System.Windows.Forms.ListBox lstChampions;
        private System.Windows.Forms.Label lblAbilities;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lstName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddToDatabase;
        private System.Windows.Forms.TextBox txtAddMoveSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddMagicResist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddAttackSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddArmor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddAttackDamage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddHealthRegen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddHealth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAbility;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddAbility;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstChampionAbility;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAssignAbility;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstAbilities;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

