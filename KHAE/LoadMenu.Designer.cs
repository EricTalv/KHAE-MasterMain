namespace KHAE
{
    partial class LoadMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBLoads = new System.Windows.Forms.ListBox();
            this.BLoad = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Alsina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load Save";
            // 
            // LBLoads
            // 
            this.LBLoads.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LBLoads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLoads.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LBLoads.FormattingEnabled = true;
            this.LBLoads.ItemHeight = 20;
            this.LBLoads.Location = new System.Drawing.Point(18, 78);
            this.LBLoads.Name = "LBLoads";
            this.LBLoads.Size = new System.Drawing.Size(538, 204);
            this.LBLoads.TabIndex = 1;
            // 
            // BLoad
            // 
            this.BLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BLoad.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BLoad.Location = new System.Drawing.Point(466, 299);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(90, 41);
            this.BLoad.TabIndex = 3;
            this.BLoad.Text = "Load";
            this.BLoad.UseVisualStyleBackColor = false;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCancel.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCancel.Location = new System.Drawing.Point(18, 299);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(90, 41);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LoadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(568, 352);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BLoad);
            this.Controls.Add(this.LBLoads);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadMenu";
            this.Text = "LoadMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoadMenu_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBLoads;
        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Button BCancel;
    }
}