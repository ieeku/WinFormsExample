namespace EwApp
{
    partial class TotalForm
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(21, 20);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 478);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(641, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AutoGenerateColumns = false;
            this.itemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Date});
            this.itemsGridView.DataSource = this.itemBindingSource;
            this.itemsGridView.Location = new System.Drawing.Point(12, 48);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.Size = new System.Drawing.Size(641, 264);
            this.itemsGridView.TabIndex = 4;
            this.itemsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Action";
            this.dataGridViewTextBoxColumn9.HeaderText = "Action";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(EwApp.Models.Item);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(55, 20);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 13);
            this.amountLabel.TabIndex = 5;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(12, 318);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(641, 154);
            this.notesTextBox.TabIndex = 6;
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 513);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TotalForm";
            this.Text = "Total";
            this.Load += new System.EventHandler(this.TotalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}

