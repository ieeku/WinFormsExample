using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwApp.Models
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public ItemAction Action { get; set; }
        public string Notes { get; set; }
    }

    public enum ItemAction
    {
        Deposit,
        Withdrawal
    }
}
