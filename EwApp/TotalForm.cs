using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class TotalForm : Form
    {
        public BindingList<Item> Items { get; set; } = new BindingList<Item>();

        public TotalForm()
        {
            InitializeComponent();

            Items.ListChanged += Items_ListChanged;
        }

        private void TotalForm_Load(object sender, EventArgs e)
        {
            itemsGridView.DataSource = Items;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();

            addForm.ShowDialog(this);
        }

        private void Items_ListChanged(object sender, ListChangedEventArgs e)
        {
            decimal total = 0;

            foreach(var item in Items)
            {
                switch (item.Action)
                {
                    case (ItemAction.Deposit):
                        total = total + item.Amount;
                        break;
                    case (ItemAction.Withdrawal):
                        total = total - item.Amount;
                        break;
                }
            }

            amountLabel.Text = total.ToString();

            if (total <= 0)
            {
                amountLabel.ForeColor = Color.Red;

                Console.Beep();
                Console.Beep();
            }
            else
            {
                amountLabel.ForeColor = Color.Green;
            }
        }

        private void ItemsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            notesTextBox.Text = Items.ElementAtOrDefault(e.RowIndex)?.Notes;
        }
    }
}
