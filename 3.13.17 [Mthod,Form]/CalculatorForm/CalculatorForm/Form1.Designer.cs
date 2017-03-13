namespace CalculatorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.resultLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(139, 58);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(190, 20);
            this.firstNumberTextBox.TabIndex = 3;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(139, 89);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(190, 20);
            this.secondNumberTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(139, 141);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Addition";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(253, 140);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 7;
            this.subButton.Text = "Substruction";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(139, 200);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(75, 23);
            this.mulButton.TabIndex = 8;
            this.mulButton.Text = "Multiply";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(253, 200);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(75, 23);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "Division";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // resultLebel
            // 
            this.resultLebel.AutoSize = true;
            this.resultLebel.Location = new System.Drawing.Point(139, 251);
            this.resultLebel.Name = "resultLebel";
            this.resultLebel.Size = new System.Drawing.Size(19, 13);
            this.resultLebel.TabIndex = 10;
            this.resultLebel.Text = "00";
            this.resultLebel.Click += new System.EventHandler(this.resultLebel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 329);
            this.Controls.Add(this.resultLebel);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Label resultLebel;
    }
}

