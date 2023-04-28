namespace DatabaseFinalProject
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.First_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prefered_Foot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jersey_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Market_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Goals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yellow_Cards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Red_Cards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Matches = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First_Name,
            this.Last_Name,
            this.Position,
            this.Country,
            this.Age,
            this.Prefered_Foot,
            this.Jersey_Number,
            this.Market_Value,
            this.Matches,
            this.Goals,
            this.Assists,
            this.Yellow_Cards,
            this.Red_Cards});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1479, 73);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // First_Name
            // 
            this.First_Name.Text = "First Name";
            this.First_Name.Width = 100;
            // 
            // Last_Name
            // 
            this.Last_Name.Text = "Last Name";
            this.Last_Name.Width = 100;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 125;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 100;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 40;
            // 
            // Prefered_Foot
            // 
            this.Prefered_Foot.Text = "Prefered Foot";
            this.Prefered_Foot.Width = 101;
            // 
            // Jersey_Number
            // 
            this.Jersey_Number.Text = "Jersey #";
            this.Jersey_Number.Width = 70;
            // 
            // Market_Value
            // 
            this.Market_Value.Text = "Market Value";
            this.Market_Value.Width = 95;
            // 
            // Goals
            // 
            this.Goals.Text = "Goals";
            this.Goals.Width = 50;
            // 
            // Assists
            // 
            this.Assists.Text = "Assists";
            // 
            // Yellow_Cards
            // 
            this.Yellow_Cards.Text = "Yellow Cards";
            this.Yellow_Cards.Width = 95;
            // 
            // Red_Cards
            // 
            this.Red_Cards.Text = "Red Cards";
            this.Red_Cards.Width = 85;
            // 
            // Matches
            // 
            this.Matches.Text = "Matches";
            this.Matches.Width = 70;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DatabaseFinalProject.Properties.Resources.tottenham_art;
            this.ClientSize = new System.Drawing.Size(1503, 99);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Last_Name;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Prefered_Foot;
        private System.Windows.Forms.ColumnHeader Jersey_Number;
        private System.Windows.Forms.ColumnHeader Market_Value;
        private System.Windows.Forms.ColumnHeader Goals;
        private System.Windows.Forms.ColumnHeader Assists;
        private System.Windows.Forms.ColumnHeader Yellow_Cards;
        private System.Windows.Forms.ColumnHeader Red_Cards;
        private System.Windows.Forms.ColumnHeader Matches;
    }
}