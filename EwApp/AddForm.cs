using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EwApp.Models;

namespace EwApp
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            actionComboBox.DataSource = Enum.GetValues(typeof(ItemAction));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (actionComboBox.SelectedValue == null || 
                !Enum.TryParse(actionComboBox.SelectedValue.ToString(), out ItemAction action))
            {
                MessageBox.Show("Please enter a valid action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (string.IsNullOrEmpty(amountNumericUpDown.Text) || 
                !decimal.TryParse(amountNumericUpDown.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((TotalForm)Owner).Items.Add(new Item
            {
                Name = nameTextBox.Text,
                Amount = amount,
                Date = dateTimePicker.Value.ToLocalTime().ToString(),
                Action = action,
                Notes = notesTextBox.Text
            });

            Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            nameTextBox.ResetText();
            dateTimePicker.Value = DateTime.Now;
            actionComboBox.SelectedIndex = actionComboBox.FindStringExact(ItemAction.Deposit.ToString());
            amountNumericUpDown.Value = 1;
            notesTextBox.ResetText();
        }
    }
}