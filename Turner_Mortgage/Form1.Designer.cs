namespace Turner_Mortgage
{
    partial class frmMortgageCalculator
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPrincipalWhole = new System.Windows.Forms.TextBox();
            this.lblTerms = new System.Windows.Forms.Label();
            this.rbtn15 = new System.Windows.Forms.RadioButton();
            this.rbtn30 = new System.Windows.Forms.RadioButton();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.lblInterest = new System.Windows.Forms.Label();
            this.cmbInterestValue = new System.Windows.Forms.ComboBox();
            this.btnCaclulate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPaymentFinal = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(40, 46);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(100, 23);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal:";
            // 
            // txtPrincipalWhole
            // 
            this.txtPrincipalWhole.Location = new System.Drawing.Point(146, 51);
            this.txtPrincipalWhole.Name = "txtPrincipalWhole";
            this.txtPrincipalWhole.Size = new System.Drawing.Size(157, 20);
            this.txtPrincipalWhole.TabIndex = 1;
            this.txtPrincipalWhole.Text = "Enter Principal in whole number";
            this.txtPrincipalWhole.TextChanged += new System.EventHandler(this.txtPrincipalWhole_TextChanged);
            this.txtPrincipalWhole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipalWhole_KeyPress);
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.Location = new System.Drawing.Point(40, 83);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(142, 23);
            this.lblTerms.TabIndex = 2;
            this.lblTerms.Text = "Term in Years";
            // 
            // rbtn15
            // 
            this.rbtn15.AutoSize = true;
            this.rbtn15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn15.Location = new System.Drawing.Point(44, 118);
            this.rbtn15.Name = "rbtn15";
            this.rbtn15.Size = new System.Drawing.Size(101, 27);
            this.rbtn15.TabIndex = 3;
            this.rbtn15.TabStop = true;
            this.rbtn15.Text = "15 Year";
            this.rbtn15.UseVisualStyleBackColor = true;
            // 
            // rbtn30
            // 
            this.rbtn30.AutoSize = true;
            this.rbtn30.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn30.Location = new System.Drawing.Point(44, 151);
            this.rbtn30.Name = "rbtn30";
            this.rbtn30.Size = new System.Drawing.Size(101, 27);
            this.rbtn30.TabIndex = 4;
            this.rbtn30.TabStop = true;
            this.rbtn30.Text = "30 Year";
            this.rbtn30.UseVisualStyleBackColor = true;
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOther.Location = new System.Drawing.Point(44, 185);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(100, 27);
            this.rbtnOther.TabIndex = 5;
            this.rbtnOther.TabStop = true;
            this.rbtnOther.Text = "Other...";
            this.rbtnOther.UseVisualStyleBackColor = true;
            this.rbtnOther.CheckedChanged += new System.EventHandler(this.rbtnOther_CheckedChanged);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(40, 223);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(87, 23);
            this.lblInterest.TabIndex = 6;
            this.lblInterest.Text = "Interest";
            this.lblInterest.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbInterestValue
            // 
            this.cmbInterestValue.FormattingEnabled = true;
            this.cmbInterestValue.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cmbInterestValue.Location = new System.Drawing.Point(146, 225);
            this.cmbInterestValue.Name = "cmbInterestValue";
            this.cmbInterestValue.Size = new System.Drawing.Size(121, 21);
            this.cmbInterestValue.TabIndex = 7;
            this.cmbInterestValue.SelectedIndexChanged += new System.EventHandler(this.cmbInterestValue_SelectedIndexChanged);
            // 
            // btnCaclulate
            // 
            this.btnCaclulate.Location = new System.Drawing.Point(44, 252);
            this.btnCaclulate.Name = "btnCaclulate";
            this.btnCaclulate.Size = new System.Drawing.Size(223, 41);
            this.btnCaclulate.TabIndex = 8;
            this.btnCaclulate.Text = "Calculate Payment";
            this.btnCaclulate.UseVisualStyleBackColor = true;
            this.btnCaclulate.Click += new System.EventHandler(this.btnCaclulate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(162, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(44, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPaymentFinal
            // 
            this.lblPaymentFinal.AutoSize = true;
            this.lblPaymentFinal.Location = new System.Drawing.Point(45, 360);
            this.lblPaymentFinal.Name = "lblPaymentFinal";
            this.lblPaymentFinal.Size = new System.Drawing.Size(0, 13);
            this.lblPaymentFinal.TabIndex = 11;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(156, 185);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(111, 20);
            this.txtOther.TabIndex = 12;
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalResult.Location = new System.Drawing.Point(43, 348);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(59, 19);
            this.lblFinalResult.TabIndex = 13;
            this.lblFinalResult.Text = "label1";
            this.lblFinalResult.Click += new System.EventHandler(this.lblFinalResult_Click_1);
            // 
            // frmMortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.lblFinalResult);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.lblPaymentFinal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCaclulate);
            this.Controls.Add(this.cmbInterestValue);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.rbtnOther);
            this.Controls.Add(this.rbtn30);
            this.Controls.Add(this.rbtn15);
            this.Controls.Add(this.lblTerms);
            this.Controls.Add(this.txtPrincipalWhole);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "frmMortgageCalculator";
            this.Text = "Vibe Turner : Mortgage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPrincipalWhole;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.RadioButton rbtn15;
        private System.Windows.Forms.RadioButton rbtn30;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.ComboBox cmbInterestValue;
        private System.Windows.Forms.Button btnCaclulate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPaymentFinal;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblFinalResult;
    }
}

