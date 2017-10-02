namespace KHAE
{
    partial class SaveMenu
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
            this.BOk = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alsina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saving...";
            // 
            // BOk
            // 
            this.BOk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BOk.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BOk.Location = new System.Drawing.Point(235, 107);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(162, 41);
            this.BOk.TabIndex = 2;
            this.BOk.Text = "Ok";
            this.BOk.UseVisualStyleBackColor = false;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCancel.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCancel.Location = new System.Drawing.Point(25, 107);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(162, 41);
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Alsina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chapter 1: Lets Begin                      WED/28/09/17";
            // 
            // SaveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(423, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveMenu";
            this.Text = "SaveMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveMenu_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Label label2;
    }
}