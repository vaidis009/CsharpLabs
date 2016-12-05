namespace MultipleConverter
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
            this.lblConverted = new System.Windows.Forms.Label();
            this.inchesSelected = new System.Windows.Forms.RadioButton();
            this.poundSelected = new System.Windows.Forms.RadioButton();
            this.celciusSelected = new System.Windows.Forms.RadioButton();
            this.inputField = new System.Windows.Forms.TextBox();
            this.lblInputs = new System.Windows.Forms.Label();
            this.ConvertedValueBox = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.ConvertedValueBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConverted
            // 
            this.lblConverted.AutoSize = true;
            this.lblConverted.Location = new System.Drawing.Point(101, 25);
            this.lblConverted.Name = "lblConverted";
            this.lblConverted.Size = new System.Drawing.Size(25, 13);
            this.lblConverted.TabIndex = 0;
            this.lblConverted.Text = "......";
            this.lblConverted.Click += new System.EventHandler(this.label1_Click);
            // 
            // inchesSelected
            // 
            this.inchesSelected.AutoSize = true;
            this.inchesSelected.Location = new System.Drawing.Point(46, 56);
            this.inchesSelected.Name = "inchesSelected";
            this.inchesSelected.Size = new System.Drawing.Size(93, 17);
            this.inchesSelected.TabIndex = 1;
            this.inchesSelected.TabStop = true;
            this.inchesSelected.Text = "Inches to Feet";
            this.inchesSelected.UseVisualStyleBackColor = true;
            this.inchesSelected.CheckedChanged += new System.EventHandler(this.inchesSelected_CheckedChanged);
            // 
            // poundSelected
            // 
            this.poundSelected.AutoSize = true;
            this.poundSelected.Location = new System.Drawing.Point(168, 56);
            this.poundSelected.Name = "poundSelected";
            this.poundSelected.Size = new System.Drawing.Size(93, 17);
            this.poundSelected.TabIndex = 2;
            this.poundSelected.TabStop = true;
            this.poundSelected.Text = "Pound to Euro";
            this.poundSelected.UseVisualStyleBackColor = true;
            this.poundSelected.CheckedChanged += new System.EventHandler(this.poundSelected_CheckedChanged);
            // 
            // celciusSelected
            // 
            this.celciusSelected.AutoSize = true;
            this.celciusSelected.Location = new System.Drawing.Point(288, 56);
            this.celciusSelected.Name = "celciusSelected";
            this.celciusSelected.Size = new System.Drawing.Size(124, 17);
            this.celciusSelected.TabIndex = 3;
            this.celciusSelected.TabStop = true;
            this.celciusSelected.Text = "Celcius to Fahrenheit";
            this.celciusSelected.UseVisualStyleBackColor = true;
            this.celciusSelected.CheckedChanged += new System.EventHandler(this.celciusSelected_CheckedChanged);
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(150, 116);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(100, 20);
            this.inputField.TabIndex = 4;
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.Location = new System.Drawing.Point(150, 97);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(97, 13);
            this.lblInputs.TabIndex = 5;
            this.lblInputs.Text = "Please Enter Units:";
            // 
            // ConvertedValueBox
            // 
            this.ConvertedValueBox.Controls.Add(this.lblResults);
            this.ConvertedValueBox.Controls.Add(this.lblConverted);
            this.ConvertedValueBox.Location = new System.Drawing.Point(101, 142);
            this.ConvertedValueBox.Name = "ConvertedValueBox";
            this.ConvertedValueBox.Size = new System.Drawing.Size(200, 57);
            this.ConvertedValueBox.TabIndex = 6;
            this.ConvertedValueBox.TabStop = false;
            this.ConvertedValueBox.Text = "Converted Value";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(34, 25);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results:";
            this.lblResults.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(124, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(205, 205);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 239);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ConvertedValueBox);
            this.Controls.Add(this.lblInputs);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.celciusSelected);
            this.Controls.Add(this.poundSelected);
            this.Controls.Add(this.inchesSelected);
            this.Name = "Form1";
            this.Text = "Multiple Converter";
            this.ConvertedValueBox.ResumeLayout(false);
            this.ConvertedValueBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConverted;
        private System.Windows.Forms.RadioButton inchesSelected;
        private System.Windows.Forms.RadioButton poundSelected;
        private System.Windows.Forms.RadioButton celciusSelected;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label lblInputs;
        private System.Windows.Forms.GroupBox ConvertedValueBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResults;
    }
}

