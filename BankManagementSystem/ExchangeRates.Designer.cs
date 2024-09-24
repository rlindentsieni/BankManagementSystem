namespace BankManagementSystem
{
    partial class ExchangeRates
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoUSD = new System.Windows.Forms.RadioButton();
            this.rdoZAR = new System.Windows.Forms.RadioButton();
            this.rdoEURO = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCurrencies = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.cmbConvertTo = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert between the following currencies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(40, 254);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(205, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvert.Location = new System.Drawing.Point(261, 236);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 40);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(57, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 293);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency converter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResults);
            this.groupBox2.Controls.Add(this.lblCurrencies);
            this.groupBox2.Location = new System.Drawing.Point(460, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 178);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoUSD);
            this.groupBox3.Controls.Add(this.rdoZAR);
            this.groupBox3.Controls.Add(this.rdoEURO);
            this.groupBox3.Location = new System.Drawing.Point(40, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 155);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coonverting from?";
            // 
            // rdoUSD
            // 
            this.rdoUSD.AutoSize = true;
            this.rdoUSD.ForeColor = System.Drawing.Color.Red;
            this.rdoUSD.Location = new System.Drawing.Point(37, 72);
            this.rdoUSD.Name = "rdoUSD";
            this.rdoUSD.Size = new System.Drawing.Size(57, 20);
            this.rdoUSD.TabIndex = 6;
            this.rdoUSD.TabStop = true;
            this.rdoUSD.Text = "USD";
            this.rdoUSD.UseVisualStyleBackColor = true;
            this.rdoUSD.CheckedChanged += new System.EventHandler(this.rdoUSD_CheckedChanged);
            // 
            // rdoZAR
            // 
            this.rdoZAR.AutoSize = true;
            this.rdoZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoZAR.ForeColor = System.Drawing.Color.Red;
            this.rdoZAR.Location = new System.Drawing.Point(37, 39);
            this.rdoZAR.Name = "rdoZAR";
            this.rdoZAR.Size = new System.Drawing.Size(51, 19);
            this.rdoZAR.TabIndex = 5;
            this.rdoZAR.TabStop = true;
            this.rdoZAR.Text = "ZAR";
            this.rdoZAR.UseVisualStyleBackColor = true;
            this.rdoZAR.CheckedChanged += new System.EventHandler(this.rdoZAR_CheckedChanged);
            // 
            // rdoEURO
            // 
            this.rdoEURO.AutoSize = true;
            this.rdoEURO.ForeColor = System.Drawing.Color.Red;
            this.rdoEURO.Location = new System.Drawing.Point(37, 107);
            this.rdoEURO.Name = "rdoEURO";
            this.rdoEURO.Size = new System.Drawing.Size(67, 20);
            this.rdoEURO.TabIndex = 7;
            this.rdoEURO.TabStop = true;
            this.rdoEURO.Text = "EURO";
            this.rdoEURO.UseVisualStyleBackColor = true;
            this.rdoEURO.CheckedChanged += new System.EventHandler(this.rdoEURO_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbConvertTo);
            this.groupBox4.Location = new System.Drawing.Point(212, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 155);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coonverting to?";
            // 
            // lblCurrencies
            // 
            this.lblCurrencies.AutoSize = true;
            this.lblCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencies.Location = new System.Drawing.Point(124, 65);
            this.lblCurrencies.Name = "lblCurrencies";
            this.lblCurrencies.Size = new System.Drawing.Size(69, 16);
            this.lblCurrencies.TabIndex = 15;
            this.lblCurrencies.Text = "currencies";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(124, 114);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(58, 18);
            this.lblResults.TabIndex = 18;
            this.lblResults.Text = "Results";
            // 
            // cmbConvertTo
            // 
            this.cmbConvertTo.FormattingEnabled = true;
            this.cmbConvertTo.Items.AddRange(new object[] {
            "ZAR",
            "USD",
            "EURO"});
            this.cmbConvertTo.Location = new System.Drawing.Point(8, 68);
            this.cmbConvertTo.Name = "cmbConvertTo";
            this.cmbConvertTo.Size = new System.Drawing.Size(121, 24);
            this.cmbConvertTo.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(556, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ExchangeRates";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoUSD;
        private System.Windows.Forms.RadioButton rdoZAR;
        private System.Windows.Forms.RadioButton rdoEURO;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCurrencies;
        private System.Windows.Forms.ComboBox cmbConvertTo;
        private System.Windows.Forms.Button btnBack;
    }
}