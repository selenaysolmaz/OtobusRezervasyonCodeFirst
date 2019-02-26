namespace quiz1
{
    partial class FormControl
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
            this.lBNameSurname = new System.Windows.Forms.ListBox();
            this.lBTrip = new System.Windows.Forms.ListBox();
            this.lBSeatNumber = new System.Windows.Forms.ListBox();
            this.lBPlateNumber = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tstTel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lBNameSurname
            // 
            this.lBNameSurname.FormattingEnabled = true;
            this.lBNameSurname.Location = new System.Drawing.Point(493, 44);
            this.lBNameSurname.Margin = new System.Windows.Forms.Padding(2);
            this.lBNameSurname.Name = "lBNameSurname";
            this.lBNameSurname.Size = new System.Drawing.Size(91, 199);
            this.lBNameSurname.TabIndex = 6;
            // 
            // lBTrip
            // 
            this.lBTrip.FormattingEnabled = true;
            this.lBTrip.Location = new System.Drawing.Point(317, 44);
            this.lBTrip.Margin = new System.Windows.Forms.Padding(2);
            this.lBTrip.Name = "lBTrip";
            this.lBTrip.Size = new System.Drawing.Size(152, 199);
            this.lBTrip.TabIndex = 7;
            // 
            // lBSeatNumber
            // 
            this.lBSeatNumber.FormattingEnabled = true;
            this.lBSeatNumber.Location = new System.Drawing.Point(198, 44);
            this.lBSeatNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lBSeatNumber.Name = "lBSeatNumber";
            this.lBSeatNumber.Size = new System.Drawing.Size(91, 199);
            this.lBSeatNumber.TabIndex = 8;
            // 
            // lBPlateNumber
            // 
            this.lBPlateNumber.FormattingEnabled = true;
            this.lBPlateNumber.Location = new System.Drawing.Point(82, 44);
            this.lBPlateNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lBPlateNumber.Name = "lBPlateNumber";
            this.lBPlateNumber.Size = new System.Drawing.Size(91, 199);
            this.lBPlateNumber.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Location = new System.Drawing.Point(363, 15);
            this.lblTrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(32, 13);
            this.lblTrip.TabIndex = 3;
            this.lblTrip.Text = "Sefer";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(196, 15);
            this.lblSeatNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(57, 13);
            this.lblSeatNumber.TabIndex = 4;
            this.lblSeatNumber.Text = "Koltuk No:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(82, 15);
            this.lblPlateNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(54, 13);
            this.lblPlateNumber.TabIndex = 5;
            this.lblPlateNumber.Text = "Plaka No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "iletisim";
            // 
            // tstTel
            // 
            this.tstTel.FormattingEnabled = true;
            this.tstTel.Location = new System.Drawing.Point(601, 44);
            this.tstTel.Margin = new System.Windows.Forms.Padding(2);
            this.tstTel.Name = "tstTel";
            this.tstTel.Size = new System.Drawing.Size(91, 199);
            this.tstTel.TabIndex = 6;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 305);
            this.Controls.Add(this.tstTel);
            this.Controls.Add(this.lBNameSurname);
            this.Controls.Add(this.lBTrip);
            this.Controls.Add(this.lBSeatNumber);
            this.Controls.Add(this.lBPlateNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.lblPlateNumber);
            this.Name = "FormControl";
            this.Text = "FormControl";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBNameSurname;
        private System.Windows.Forms.ListBox lBTrip;
        private System.Windows.Forms.ListBox lBSeatNumber;
        private System.Windows.Forms.ListBox lBPlateNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tstTel;
    }
}