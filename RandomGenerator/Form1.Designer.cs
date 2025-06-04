namespace RandomGenerator
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
            this.components = new System.ComponentModel.Container();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.nudDigitsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSpecialCharacter = new System.Windows.Forms.RadioButton();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.rbNumbers = new System.Windows.Forms.RadioButton();
            this.rbLetters = new System.Windows.Forms.RadioButton();
            this.cmLetterStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.capitalLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigitsCount)).BeginInit();
            this.cmLetterStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.nudDigitsCount);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.rbSpecialCharacter);
            this.gbDetails.Controls.Add(this.rbMix);
            this.gbDetails.Controls.Add(this.rbNumbers);
            this.gbDetails.Controls.Add(this.rbLetters);
            this.gbDetails.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(203, 185);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(255, 165);
            this.gbDetails.TabIndex = 0;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // nudDigitsCount
            // 
            this.nudDigitsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDigitsCount.Location = new System.Drawing.Point(129, 37);
            this.nudDigitsCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDigitsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDigitsCount.Name = "nudDigitsCount";
            this.nudDigitsCount.Size = new System.Drawing.Size(120, 23);
            this.nudDigitsCount.TabIndex = 0;
            this.nudDigitsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Symbols Count";
            // 
            // rbSpecialCharacter
            // 
            this.rbSpecialCharacter.AutoSize = true;
            this.rbSpecialCharacter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpecialCharacter.ForeColor = System.Drawing.Color.White;
            this.rbSpecialCharacter.Location = new System.Drawing.Point(6, 128);
            this.rbSpecialCharacter.Name = "rbSpecialCharacter";
            this.rbSpecialCharacter.Size = new System.Drawing.Size(139, 20);
            this.rbSpecialCharacter.TabIndex = 3;
            this.rbSpecialCharacter.TabStop = true;
            this.rbSpecialCharacter.Text = "Special Character";
            this.rbSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.ForeColor = System.Drawing.Color.White;
            this.rbMix.Location = new System.Drawing.Point(168, 128);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(46, 20);
            this.rbMix.TabIndex = 4;
            this.rbMix.TabStop = true;
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            // 
            // rbNumbers
            // 
            this.rbNumbers.AutoSize = true;
            this.rbNumbers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumbers.ForeColor = System.Drawing.Color.White;
            this.rbNumbers.Location = new System.Drawing.Point(168, 84);
            this.rbNumbers.Name = "rbNumbers";
            this.rbNumbers.Size = new System.Drawing.Size(81, 20);
            this.rbNumbers.TabIndex = 2;
            this.rbNumbers.TabStop = true;
            this.rbNumbers.Text = "Numbers";
            this.rbNumbers.UseVisualStyleBackColor = true;
            // 
            // rbLetters
            // 
            this.rbLetters.AutoSize = true;
            this.rbLetters.Checked = true;
            this.rbLetters.ContextMenuStrip = this.cmLetterStatus;
            this.rbLetters.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLetters.ForeColor = System.Drawing.Color.White;
            this.rbLetters.Location = new System.Drawing.Point(6, 84);
            this.rbLetters.Name = "rbLetters";
            this.rbLetters.Size = new System.Drawing.Size(73, 20);
            this.rbLetters.TabIndex = 1;
            this.rbLetters.TabStop = true;
            this.rbLetters.Text = "Letters";
            this.rbLetters.UseVisualStyleBackColor = true;
            // 
            // cmLetterStatus
            // 
            this.cmLetterStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitalLetterToolStripMenuItem,
            this.smallLetterToolStripMenuItem});
            this.cmLetterStatus.Name = "cmLetterStatus";
            this.cmLetterStatus.Size = new System.Drawing.Size(145, 48);
            // 
            // capitalLetterToolStripMenuItem
            // 
            this.capitalLetterToolStripMenuItem.Checked = true;
            this.capitalLetterToolStripMenuItem.CheckOnClick = true;
            this.capitalLetterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.capitalLetterToolStripMenuItem.Name = "capitalLetterToolStripMenuItem";
            this.capitalLetterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.capitalLetterToolStripMenuItem.Text = "Capital Latter";
            this.capitalLetterToolStripMenuItem.Click += new System.EventHandler(this.capitalLetterToolStripMenuItem_Click);
            // 
            // smallLetterToolStripMenuItem
            // 
            this.smallLetterToolStripMenuItem.CheckOnClick = true;
            this.smallLetterToolStripMenuItem.Name = "smallLetterToolStripMenuItem";
            this.smallLetterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.smallLetterToolStripMenuItem.Text = "Small Letter";
            this.smallLetterToolStripMenuItem.Click += new System.EventHandler(this.smallLetterToolStripMenuItem_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(203, 364);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(108, 39);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(350, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 39);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(290, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "__________________________________________";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(200, 120);
            this.txtResult.MaxLength = 30;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(259, 16);
            this.txtResult.TabIndex = 7;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigitsCount)).EndInit();
            this.cmLetterStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSpecialCharacter;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.RadioButton rbNumbers;
        private System.Windows.Forms.RadioButton rbLetters;
        private System.Windows.Forms.NumericUpDown nudDigitsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmLetterStatus;
        private System.Windows.Forms.ToolStripMenuItem capitalLetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallLetterToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResult;
    }
}

