namespace KHAE
{
    partial class ProfilesMenu
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
            this.Profiles = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Profiles
            // 
            this.Profiles.AutoSize = true;
            this.Profiles.Font = new System.Drawing.Font("Alsina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profiles.Location = new System.Drawing.Point(25, 19);
            this.Profiles.Name = "Profiles";
            this.Profiles.Size = new System.Drawing.Size(126, 38);
            this.Profiles.TabIndex = 0;
            this.Profiles.Text = "Profiles ;-;";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileName,
            this.Chapter,
            this.DateAdded});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(111, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 132);
            this.dataGridView1.TabIndex = 1;
            // 
            // ProfileName
            // 
            this.ProfileName.HeaderText = "Profile Name";
            this.ProfileName.Name = "ProfileName";
            // 
            // Chapter
            // 
            this.Chapter.HeaderText = "Chapter";
            this.Chapter.Name = "Chapter";
            // 
            // DateAdded
            // 
            this.DateAdded.HeaderText = "Date Added";
            this.DateAdded.Name = "DateAdded";
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCancel.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCancel.Location = new System.Drawing.Point(32, 179);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(443, 199);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // ProfilesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(487, 399);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Profiles);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilesMenu";
            this.Text = "ProfilesMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Profiles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.Button BCancel;
    }
}