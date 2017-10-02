namespace KHAE
{
    partial class SettingsMenu
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
            this.LMasterVolume = new System.Windows.Forms.Label();
            this.LSoundFX = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.GBxAudio = new System.Windows.Forms.GroupBox();
            this.TBMusicV = new System.Windows.Forms.TrackBar();
            this.LMusicV = new System.Windows.Forms.Label();
            this.AudioCheck = new System.Windows.Forms.CheckBox();
            this.TBSoundFX = new System.Windows.Forms.TrackBar();
            this.TBMasterV = new System.Windows.Forms.TrackBar();
            this.GBxColor = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.CBxLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBxQuality = new System.Windows.Forms.ListBox();
            this.BApply = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GBxAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBMusicV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSoundFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMasterV)).BeginInit();
            this.GBxColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Alsina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // LMasterVolume
            // 
            this.LMasterVolume.AutoSize = true;
            this.LMasterVolume.Font = new System.Drawing.Font("Alsina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMasterVolume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LMasterVolume.Location = new System.Drawing.Point(12, 45);
            this.LMasterVolume.Name = "LMasterVolume";
            this.LMasterVolume.Size = new System.Drawing.Size(117, 27);
            this.LMasterVolume.TabIndex = 1;
            this.LMasterVolume.Text = "Master Volume";
            // 
            // LSoundFX
            // 
            this.LSoundFX.AutoSize = true;
            this.LSoundFX.Font = new System.Drawing.Font("Alsina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSoundFX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSoundFX.Location = new System.Drawing.Point(15, 201);
            this.LSoundFX.Name = "LSoundFX";
            this.LSoundFX.Size = new System.Drawing.Size(39, 27);
            this.LSoundFX.TabIndex = 2;
            this.LSoundFX.Text = "SFX";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Alsina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(26, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 31);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // GBxAudio
            // 
            this.GBxAudio.Controls.Add(this.TBMusicV);
            this.GBxAudio.Controls.Add(this.LMusicV);
            this.GBxAudio.Controls.Add(this.AudioCheck);
            this.GBxAudio.Controls.Add(this.TBSoundFX);
            this.GBxAudio.Controls.Add(this.TBMasterV);
            this.GBxAudio.Controls.Add(this.LSoundFX);
            this.GBxAudio.Controls.Add(this.LMasterVolume);
            this.GBxAudio.Font = new System.Drawing.Font("Alsina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxAudio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GBxAudio.Location = new System.Drawing.Point(12, 71);
            this.GBxAudio.Name = "GBxAudio";
            this.GBxAudio.Size = new System.Drawing.Size(221, 285);
            this.GBxAudio.TabIndex = 8;
            this.GBxAudio.TabStop = false;
            this.GBxAudio.Text = "    Audio";
            // 
            // TBMusicV
            // 
            this.TBMusicV.LargeChange = 1;
            this.TBMusicV.Location = new System.Drawing.Point(17, 153);
            this.TBMusicV.Name = "TBMusicV";
            this.TBMusicV.Size = new System.Drawing.Size(190, 45);
            this.TBMusicV.TabIndex = 7;
            // 
            // LMusicV
            // 
            this.LMusicV.AutoSize = true;
            this.LMusicV.Font = new System.Drawing.Font("Alsina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMusicV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LMusicV.Location = new System.Drawing.Point(12, 123);
            this.LMusicV.Name = "LMusicV";
            this.LMusicV.Size = new System.Drawing.Size(53, 27);
            this.LMusicV.TabIndex = 6;
            this.LMusicV.Text = "Music";
            // 
            // AudioCheck
            // 
            this.AudioCheck.AutoSize = true;
            this.AudioCheck.Checked = true;
            this.AudioCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AudioCheck.Location = new System.Drawing.Point(17, 11);
            this.AudioCheck.Name = "AudioCheck";
            this.AudioCheck.Size = new System.Drawing.Size(15, 14);
            this.AudioCheck.TabIndex = 5;
            this.AudioCheck.UseVisualStyleBackColor = true;
            this.AudioCheck.CheckedChanged += new System.EventHandler(this.AudioCheck_CheckedChanged);
            // 
            // TBSoundFX
            // 
            this.TBSoundFX.LargeChange = 1;
            this.TBSoundFX.Location = new System.Drawing.Point(20, 231);
            this.TBSoundFX.Name = "TBSoundFX";
            this.TBSoundFX.Size = new System.Drawing.Size(190, 45);
            this.TBSoundFX.TabIndex = 4;
            // 
            // TBMasterV
            // 
            this.TBMasterV.LargeChange = 1;
            this.TBMasterV.Location = new System.Drawing.Point(17, 75);
            this.TBMasterV.Name = "TBMasterV";
            this.TBMasterV.Size = new System.Drawing.Size(190, 45);
            this.TBMasterV.TabIndex = 3;
            // 
            // GBxColor
            // 
            this.GBxColor.Controls.Add(this.radioButton3);
            this.GBxColor.Controls.Add(this.radioButton2);
            this.GBxColor.Font = new System.Drawing.Font("Alsina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GBxColor.Location = new System.Drawing.Point(271, 134);
            this.GBxColor.Name = "GBxColor";
            this.GBxColor.Size = new System.Drawing.Size(200, 100);
            this.GBxColor.TabIndex = 9;
            this.GBxColor.TabStop = false;
            this.GBxColor.Text = "Color";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Alsina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(124, 45);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 31);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // CBxLanguage
            // 
            this.CBxLanguage.BackColor = System.Drawing.Color.Black;
            this.CBxLanguage.Font = new System.Drawing.Font("Alsina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBxLanguage.ForeColor = System.Drawing.Color.White;
            this.CBxLanguage.FormattingEnabled = true;
            this.CBxLanguage.Location = new System.Drawing.Point(271, 82);
            this.CBxLanguage.Name = "CBxLanguage";
            this.CBxLanguage.Size = new System.Drawing.Size(200, 35);
            this.CBxLanguage.TabIndex = 10;
            this.CBxLanguage.Text = "<Choose your Language>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBxQuality);
            this.groupBox1.Font = new System.Drawing.Font("Alsina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(271, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quality";
            // 
            // LBxQuality
            // 
            this.LBxQuality.BackColor = System.Drawing.Color.Black;
            this.LBxQuality.ForeColor = System.Drawing.Color.White;
            this.LBxQuality.FormattingEnabled = true;
            this.LBxQuality.ItemHeight = 33;
            this.LBxQuality.Location = new System.Drawing.Point(6, 51);
            this.LBxQuality.Name = "LBxQuality";
            this.LBxQuality.Size = new System.Drawing.Size(188, 37);
            this.LBxQuality.Sorted = true;
            this.LBxQuality.TabIndex = 0;
            // 
            // BApply
            // 
            this.BApply.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BApply.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BApply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BApply.Location = new System.Drawing.Point(271, 422);
            this.BApply.Name = "BApply";
            this.BApply.Size = new System.Drawing.Size(200, 41);
            this.BApply.TabIndex = 12;
            this.BApply.Text = "Apply";
            this.BApply.UseVisualStyleBackColor = false;
            this.BApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCancel.Font = new System.Drawing.Font("Alsina", 15.25F);
            this.BCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCancel.Location = new System.Drawing.Point(12, 372);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(221, 41);
            this.BCancel.TabIndex = 13;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 423);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 40);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Alsina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(136, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Testing";
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(483, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBxLanguage);
            this.Controls.Add(this.GBxColor);
            this.Controls.Add(this.GBxAudio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsMenu";
            this.Text = "SettingsMenu";
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsMenu_MouseDown);
            this.GBxAudio.ResumeLayout(false);
            this.GBxAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBMusicV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSoundFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBMasterV)).EndInit();
            this.GBxColor.ResumeLayout(false);
            this.GBxColor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LMasterVolume;
        private System.Windows.Forms.Label LSoundFX;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox GBxAudio;
        private System.Windows.Forms.TrackBar TBSoundFX;
        private System.Windows.Forms.TrackBar TBMasterV;
        private System.Windows.Forms.CheckBox AudioCheck;
        private System.Windows.Forms.TrackBar TBMusicV;
        private System.Windows.Forms.Label LMusicV;
        private System.Windows.Forms.GroupBox GBxColor;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox CBxLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBxQuality;
        private System.Windows.Forms.Button BApply;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}