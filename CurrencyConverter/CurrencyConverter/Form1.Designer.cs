namespace CurrencyConverter
{
    partial class Form1
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
            this.fromCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toCurrency = new System.Windows.Forms.ComboBox();
            this.btnConcert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMoneyAmountInput = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.BoxConAmount = new System.Windows.Forms.GroupBox();
            this.lblConAmount = new System.Windows.Forms.Label();
            this.BoxConAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // fromCurrency
            // 
            this.fromCurrency.FormattingEnabled = true;
            this.fromCurrency.Items.AddRange(new object[] {
            "Euro",
            "Pound",
            "US Dollar"});
            this.fromCurrency.Location = new System.Drawing.Point(75, 72);
            this.fromCurrency.Name = "fromCurrency";
            this.fromCurrency.Size = new System.Drawing.Size(121, 21);
            this.fromCurrency.TabIndex = 2;
            this.fromCurrency.SelectedIndexChanged += new System.EventHandler(this.comFrom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // toCurrency
            // 
            this.toCurrency.FormattingEnabled = true;
            this.toCurrency.Items.AddRange(new object[] {
            "Euro",
            "Pound",
            "US Dollar"});
            this.toCurrency.Location = new System.Drawing.Point(219, 72);
            this.toCurrency.Name = "toCurrency";
            this.toCurrency.Size = new System.Drawing.Size(121, 21);
            this.toCurrency.TabIndex = 4;
            // 
            // btnConcert
            // 
            this.btnConcert.Location = new System.Drawing.Point(219, 156);
            this.btnConcert.Name = "btnConcert";
            this.btnConcert.Size = new System.Drawing.Size(75, 23);
            this.btnConcert.TabIndex = 5;
            this.btnConcert.Text = "Convert";
            this.btnConcert.UseVisualStyleBackColor = true;
            this.btnConcert.Click += new System.EventHandler(this.btnConcert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMoneyAmountInput
            // 
            this.txtMoneyAmountInput.Location = new System.Drawing.Point(170, 22);
            this.txtMoneyAmountInput.Name = "txtMoneyAmountInput";
            this.txtMoneyAmountInput.Size = new System.Drawing.Size(124, 20);
            this.txtMoneyAmountInput.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(118, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // BoxConAmount
            // 
            this.BoxConAmount.Controls.Add(this.lblConAmount);
            this.BoxConAmount.ForeColor = System.Drawing.Color.Maroon;
            this.BoxConAmount.Location = new System.Drawing.Point(99, 99);
            this.BoxConAmount.Name = "BoxConAmount";
            this.BoxConAmount.Size = new System.Drawing.Size(221, 42);
            this.BoxConAmount.TabIndex = 9;
            this.BoxConAmount.TabStop = false;
            this.BoxConAmount.Text = "Convertd Amound:";
            // 
            // lblConAmount
            // 
            this.lblConAmount.AutoSize = true;
            this.lblConAmount.Location = new System.Drawing.Point(99, 20);
            this.lblConAmount.Name = "lblConAmount";
            this.lblConAmount.Size = new System.Drawing.Size(31, 13);
            this.lblConAmount.TabIndex = 0;
            this.lblConAmount.Text = "........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 191);
            this.Controls.Add(this.BoxConAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtMoneyAmountInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConcert);
            this.Controls.Add(this.toCurrency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.BoxConAmount.ResumeLayout(false);
            this.BoxConAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fromCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox toCurrency;
        private System.Windows.Forms.Button btnConcert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMoneyAmountInput;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox BoxConAmount;
        private System.Windows.Forms.Label lblConAmount;
    }
}

