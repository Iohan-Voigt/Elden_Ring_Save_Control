namespace ERSC.WindwosApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentLbl = new System.Windows.Forms.Label();
            this.ActualSaveLbl = new System.Windows.Forms.Label();
            this.savesLbl = new System.Windows.Forms.Label();
            this.SavesCbx = new System.Windows.Forms.ComboBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newSaveTxb = new System.Windows.Forms.TextBox();
            this.newSaveNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Location = new System.Drawing.Point(12, 9);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(76, 15);
            this.currentLbl.TabIndex = 0;
            this.currentLbl.Text = "Current save:";
            // 
            // ActualSaveLbl
            // 
            this.ActualSaveLbl.AutoSize = true;
            this.ActualSaveLbl.Location = new System.Drawing.Point(84, 9);
            this.ActualSaveLbl.Name = "ActualSaveLbl";
            this.ActualSaveLbl.Size = new System.Drawing.Size(42, 15);
            this.ActualSaveLbl.TabIndex = 1;
            this.ActualSaveLbl.Text = "(none)";
            // 
            // savesLbl
            // 
            this.savesLbl.AutoSize = true;
            this.savesLbl.Location = new System.Drawing.Point(12, 24);
            this.savesLbl.Name = "savesLbl";
            this.savesLbl.Size = new System.Drawing.Size(36, 15);
            this.savesLbl.TabIndex = 2;
            this.savesLbl.Text = "Saves";
            // 
            // SavesCbx
            // 
            this.SavesCbx.FormattingEnabled = true;
            this.SavesCbx.Location = new System.Drawing.Point(12, 42);
            this.SavesCbx.Name = "SavesCbx";
            this.SavesCbx.Size = new System.Drawing.Size(292, 23);
            this.SavesCbx.TabIndex = 3;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(148, 115);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(229, 115);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newSaveTxb
            // 
            this.newSaveTxb.Location = new System.Drawing.Point(12, 86);
            this.newSaveTxb.Name = "newSaveTxb";
            this.newSaveTxb.Size = new System.Drawing.Size(292, 23);
            this.newSaveTxb.TabIndex = 6;
            // 
            // newSaveNameLbl
            // 
            this.newSaveNameLbl.AutoSize = true;
            this.newSaveNameLbl.Location = new System.Drawing.Point(12, 68);
            this.newSaveNameLbl.Name = "newSaveNameLbl";
            this.newSaveNameLbl.Size = new System.Drawing.Size(93, 15);
            this.newSaveNameLbl.TabIndex = 7;
            this.newSaveNameLbl.Text = "New Save Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 145);
            this.Controls.Add(this.newSaveNameLbl);
            this.Controls.Add(this.newSaveTxb);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.SavesCbx);
            this.Controls.Add(this.savesLbl);
            this.Controls.Add(this.ActualSaveLbl);
            this.Controls.Add(this.currentLbl);
            this.Name = "Main";
            this.Text = "Elden RIng Save Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label currentLbl;
        private Label ActualSaveLbl;
        private Label savesLbl;
        private ComboBox SavesCbx;
        private Button loadBtn;
        private Button saveBtn;
        private TextBox newSaveTxb;
        private Label newSaveNameLbl;
    }
}