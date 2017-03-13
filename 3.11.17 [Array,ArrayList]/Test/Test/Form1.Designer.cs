namespace Test
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameButton = new System.Windows.Forms.Button();
            this.ContactButton = new System.Windows.Forms.Button();
            this.AddressButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(127, 52);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(314, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(127, 94);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(314, 20);
            this.ContactTextBox.TabIndex = 4;
            this.ContactTextBox.TextChanged += new System.EventHandler(this.ContactTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(127, 142);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(314, 20);
            this.AddressTextBox.TabIndex = 5;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(127, 238);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(225, 237);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 23);
            this.NameButton.TabIndex = 7;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // ContactButton
            // 
            this.ContactButton.Location = new System.Drawing.Point(127, 297);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Size = new System.Drawing.Size(75, 23);
            this.ContactButton.TabIndex = 8;
            this.ContactButton.Text = "Contact";
            this.ContactButton.UseVisualStyleBackColor = true;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(225, 297);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(75, 23);
            this.AddressButton.TabIndex = 9;
            this.AddressButton.Text = "Address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(127, 350);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(173, 23);
            this.ShowAllButton.TabIndex = 10;
            this.ShowAllButton.Text = "Show All Information";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 481);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.ContactButton);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.FullNameTextBox);
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
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button ContactButton;
        private System.Windows.Forms.Button AddressButton;
        private System.Windows.Forms.Button ShowAllButton;
    }
}

