namespace EwApp
{
    partial class AddForm
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
            System.Windows.Forms.Label dateLabel;
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(16, 48);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(55, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(406, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(55, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(406, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // actionComboBox
            // 
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.actionComboBox.Location = new System.Drawing.Point(102, 93);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(121, 21);
            this.actionComboBox.TabIndex = 8;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(142, 77);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(40, 13);
            this.actionLabel.TabIndex = 9;
            this.actionLabel.Text = "Action:";
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(242, 96);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(13, 13);
            this.dollarLabel.TabIndex = 11;
            this.dollarLabel.Text = "$";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(295, 77);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 12;
            this.amountLabel.Text = "Amount:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(154, 297);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 21);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(235, 297);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 21);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(195, 324);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(11, 135);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(450, 152);
            this.notesTextBox.TabIndex = 16;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(12, 119);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(38, 13);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "Notes:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(257, 94);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountNumericUpDown.TabIndex = 18;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.actionComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddForm";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}