namespace Converter_with_Menu
{
    partial class Converter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celciusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celciusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poundsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inchesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCelcius = new System.Windows.Forms.Panel();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblFahOutput = new System.Windows.Forms.Label();
            this.bxInputcelcius = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConver = new System.Windows.Forms.Button();
            this.panelPounds = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.lblOutputEuro = new System.Windows.Forms.Label();
            this.inputPounds = new System.Windows.Forms.TextBox();
            this.btnClearPounds = new System.Windows.Forms.Button();
            this.btnConvertPounds = new System.Windows.Forms.Button();
            this.panelInches = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.lblOutputFeets = new System.Windows.Forms.Label();
            this.inputInches = new System.Windows.Forms.TextBox();
            this.btnClearInches = new System.Windows.Forms.Button();
            this.btnConvertInches = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelCelcius.SuspendLayout();
            this.panelPounds.SuspendLayout();
            this.panelInches.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.celciusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // celciusToolStripMenuItem
            // 
            this.celciusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celciusToolStripMenuItem1,
            this.poundsToolStripMenuItem1,
            this.inchesToolStripMenuItem1});
            this.celciusToolStripMenuItem.Name = "celciusToolStripMenuItem";
            this.celciusToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.celciusToolStripMenuItem.Text = "Menu";
            // 
            // celciusToolStripMenuItem1
            // 
            this.celciusToolStripMenuItem1.Name = "celciusToolStripMenuItem1";
            this.celciusToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.celciusToolStripMenuItem1.Text = "Celcius";
            this.celciusToolStripMenuItem1.Click += new System.EventHandler(this.celciusToolStripMenuItem1_Click);
            // 
            // poundsToolStripMenuItem1
            // 
            this.poundsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.poundsToolStripMenuItem1.Name = "poundsToolStripMenuItem1";
            this.poundsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.poundsToolStripMenuItem1.Text = "Pounds";
            this.poundsToolStripMenuItem1.Click += new System.EventHandler(this.poundsToolStripMenuItem1_Click);
            // 
            // inchesToolStripMenuItem1
            // 
            this.inchesToolStripMenuItem1.Name = "inchesToolStripMenuItem1";
            this.inchesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.inchesToolStripMenuItem1.Text = "Inches";
            this.inchesToolStripMenuItem1.Click += new System.EventHandler(this.inchesToolStripMenuItem1_Click);
            // 
            // panelCelcius
            // 
            this.panelCelcius.Controls.Add(this.lblFahrenheit);
            this.panelCelcius.Controls.Add(this.lblInput);
            this.panelCelcius.Controls.Add(this.lblFahOutput);
            this.panelCelcius.Controls.Add(this.bxInputcelcius);
            this.panelCelcius.Controls.Add(this.btnClear);
            this.panelCelcius.Controls.Add(this.btnConver);
            this.panelCelcius.Location = new System.Drawing.Point(12, 27);
            this.panelCelcius.Name = "panelCelcius";
            this.panelCelcius.Size = new System.Drawing.Size(344, 201);
            this.panelCelcius.TabIndex = 1;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(73, 119);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(60, 13);
            this.lblFahrenheit.TabIndex = 5;
            this.lblFahrenheit.Text = "Fahrenheit:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(38, 80);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(104, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Please Enter Celcius";
            // 
            // lblFahOutput
            // 
            this.lblFahOutput.AutoSize = true;
            this.lblFahOutput.Location = new System.Drawing.Point(156, 119);
            this.lblFahOutput.Name = "lblFahOutput";
            this.lblFahOutput.Size = new System.Drawing.Size(25, 13);
            this.lblFahOutput.TabIndex = 3;
            this.lblFahOutput.Text = "......";
            // 
            // bxInputcelcius
            // 
            this.bxInputcelcius.Location = new System.Drawing.Point(160, 77);
            this.bxInputcelcius.Name = "bxInputcelcius";
            this.bxInputcelcius.Size = new System.Drawing.Size(100, 20);
            this.bxInputcelcius.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(185, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConver
            // 
            this.btnConver.Location = new System.Drawing.Point(266, 175);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(75, 23);
            this.btnConver.TabIndex = 0;
            this.btnConver.Text = "Convert";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // panelPounds
            // 
            this.panelPounds.Controls.Add(this.label1);
            this.panelPounds.Controls.Add(this.lblPounds);
            this.panelPounds.Controls.Add(this.lblOutputEuro);
            this.panelPounds.Controls.Add(this.inputPounds);
            this.panelPounds.Controls.Add(this.btnClearPounds);
            this.panelPounds.Controls.Add(this.btnConvertPounds);
            this.panelPounds.Location = new System.Drawing.Point(12, 27);
            this.panelPounds.Name = "panelPounds";
            this.panelPounds.Size = new System.Drawing.Size(344, 201);
            this.panelPounds.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Euro:";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(38, 80);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(106, 13);
            this.lblPounds.TabIndex = 4;
            this.lblPounds.Text = "Please Enter Pounds";
            // 
            // lblOutputEuro
            // 
            this.lblOutputEuro.AutoSize = true;
            this.lblOutputEuro.Location = new System.Drawing.Point(156, 119);
            this.lblOutputEuro.Name = "lblOutputEuro";
            this.lblOutputEuro.Size = new System.Drawing.Size(25, 13);
            this.lblOutputEuro.TabIndex = 3;
            this.lblOutputEuro.Text = "......";
            // 
            // inputPounds
            // 
            this.inputPounds.Location = new System.Drawing.Point(160, 77);
            this.inputPounds.Name = "inputPounds";
            this.inputPounds.Size = new System.Drawing.Size(100, 20);
            this.inputPounds.TabIndex = 2;
            // 
            // btnClearPounds
            // 
            this.btnClearPounds.Location = new System.Drawing.Point(185, 175);
            this.btnClearPounds.Name = "btnClearPounds";
            this.btnClearPounds.Size = new System.Drawing.Size(75, 23);
            this.btnClearPounds.TabIndex = 1;
            this.btnClearPounds.Text = "Clear";
            this.btnClearPounds.UseVisualStyleBackColor = true;
            this.btnClearPounds.Click += new System.EventHandler(this.btnClearPounds_Click);
            // 
            // btnConvertPounds
            // 
            this.btnConvertPounds.Location = new System.Drawing.Point(266, 175);
            this.btnConvertPounds.Name = "btnConvertPounds";
            this.btnConvertPounds.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPounds.TabIndex = 0;
            this.btnConvertPounds.Text = "Convert";
            this.btnConvertPounds.UseVisualStyleBackColor = true;
            this.btnConvertPounds.Click += new System.EventHandler(this.btnConvertPounds_Click);
            // 
            // panelInches
            // 
            this.panelInches.Controls.Add(this.label4);
            this.panelInches.Controls.Add(this.lblInches);
            this.panelInches.Controls.Add(this.lblOutputFeets);
            this.panelInches.Controls.Add(this.inputInches);
            this.panelInches.Controls.Add(this.btnClearInches);
            this.panelInches.Controls.Add(this.btnConvertInches);
            this.panelInches.Location = new System.Drawing.Point(12, 27);
            this.panelInches.Name = "panelInches";
            this.panelInches.Size = new System.Drawing.Size(344, 201);
            this.panelInches.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Feets:";
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(38, 80);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(102, 13);
            this.lblInches.TabIndex = 4;
            this.lblInches.Text = "Please Enter Inches";
            // 
            // lblOutputFeets
            // 
            this.lblOutputFeets.AutoSize = true;
            this.lblOutputFeets.Location = new System.Drawing.Point(156, 119);
            this.lblOutputFeets.Name = "lblOutputFeets";
            this.lblOutputFeets.Size = new System.Drawing.Size(25, 13);
            this.lblOutputFeets.TabIndex = 3;
            this.lblOutputFeets.Text = "......";
            // 
            // inputInches
            // 
            this.inputInches.Location = new System.Drawing.Point(160, 77);
            this.inputInches.Name = "inputInches";
            this.inputInches.Size = new System.Drawing.Size(100, 20);
            this.inputInches.TabIndex = 2;
            // 
            // btnClearInches
            // 
            this.btnClearInches.Location = new System.Drawing.Point(185, 175);
            this.btnClearInches.Name = "btnClearInches";
            this.btnClearInches.Size = new System.Drawing.Size(75, 23);
            this.btnClearInches.TabIndex = 1;
            this.btnClearInches.Text = "Clear";
            this.btnClearInches.UseVisualStyleBackColor = true;
            this.btnClearInches.Click += new System.EventHandler(this.btnClearInches_Click);
            // 
            // btnConvertInches
            // 
            this.btnConvertInches.Location = new System.Drawing.Point(266, 175);
            this.btnConvertInches.Name = "btnConvertInches";
            this.btnConvertInches.Size = new System.Drawing.Size(75, 23);
            this.btnConvertInches.TabIndex = 0;
            this.btnConvertInches.Text = "Convert";
            this.btnConvertInches.UseVisualStyleBackColor = true;
            this.btnConvertInches.Click += new System.EventHandler(this.btnConvertInches_Click);
            // 
            // Converter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 239);
            this.Controls.Add(this.panelInches);
            this.Controls.Add(this.panelPounds);
            this.Controls.Add(this.panelCelcius);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Converter";
            this.Text = "Converter with menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCelcius.ResumeLayout(false);
            this.panelCelcius.PerformLayout();
            this.panelPounds.ResumeLayout(false);
            this.panelPounds.PerformLayout();
            this.panelInches.ResumeLayout(false);
            this.panelInches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celciusToolStripMenuItem;
        private System.Windows.Forms.Panel panelCelcius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblFahOutput;
        private System.Windows.Forms.TextBox bxInputcelcius;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.Panel panelPounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Label lblOutputEuro;
        private System.Windows.Forms.TextBox inputPounds;
        private System.Windows.Forms.Button btnClearPounds;
        private System.Windows.Forms.Button btnConvertPounds;
        private System.Windows.Forms.Panel panelInches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblOutputFeets;
        private System.Windows.Forms.TextBox inputInches;
        private System.Windows.Forms.Button btnClearInches;
        private System.Windows.Forms.Button btnConvertInches;
        private System.Windows.Forms.ToolStripMenuItem celciusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poundsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inchesToolStripMenuItem1;
    }
}

