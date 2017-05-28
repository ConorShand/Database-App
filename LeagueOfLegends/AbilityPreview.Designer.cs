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
            this.lstAbilities = new System.Windows.Forms.ListBox();
            this.lblAbilities = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leagueOfLegendsDataSet)).BeginInit();
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
            this.lblChampions.Location = new System.Drawing.Point(64, 71);
            this.lblChampions.Name = "lblChampions";
            this.lblChampions.Size = new System.Drawing.Size(59, 13);
            this.lblChampions.TabIndex = 0;
            this.lblChampions.Text = "Champions";
            // 
            // lstChampions
            // 
            this.lstChampions.FormattingEnabled = true;
            this.lstChampions.Location = new System.Drawing.Point(31, 98);
            this.lstChampions.Name = "lstChampions";
            this.lstChampions.Size = new System.Drawing.Size(134, 199);
            this.lstChampions.TabIndex = 1;
            this.lstChampions.SelectedIndexChanged += new System.EventHandler(this.lstChampions_SelectedIndexChanged);
            // 
            // lstAbilities
            // 
            this.lstAbilities.FormattingEnabled = true;
            this.lstAbilities.Location = new System.Drawing.Point(212, 98);
            this.lstAbilities.Name = "lstAbilities";
            this.lstAbilities.Size = new System.Drawing.Size(797, 199);
            this.lstAbilities.TabIndex = 3;
            this.lstAbilities.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstAbilities_Format);
            // 
            // lblAbilities
            // 
            this.lblAbilities.AutoSize = true;
            this.lblAbilities.Location = new System.Drawing.Point(260, 71);
            this.lblAbilities.Name = "lblAbilities";
            this.lblAbilities.Size = new System.Drawing.Size(42, 13);
            this.lblAbilities.TabIndex = 2;
            this.lblAbilities.Text = "Abilities";
            // 
            // AbilityPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 536);
            this.Controls.Add(this.lstAbilities);
            this.Controls.Add(this.lblAbilities);
            this.Controls.Add(this.lstChampions);
            this.Controls.Add(this.lblChampions);
            this.Name = "AbilityPreview";
            this.Text = "Ability Preview";
            this.Load += new System.EventHandler(this.AbilityPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leagueOfLegendsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeagueOfLegendsDataSet leagueOfLegendsDataSet;
        private System.Windows.Forms.Label lblChampions;
        private System.Windows.Forms.ListBox lstChampions;
        private System.Windows.Forms.ListBox lstAbilities;
        private System.Windows.Forms.Label lblAbilities;
    }
}

