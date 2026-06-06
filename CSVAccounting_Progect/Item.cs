using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSVAccounting_Progect
{
    public class Item
    {
        public DateTime Date { get; set; }
        public string Note { get; set; }
        //public string ? Note { get; set; }
        // public string Note { get; set; }=string.Empty
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }

        public Category CategoryType { get; set; }

    }

    public enum Category //enum限制選項
    {
        食,
        衣,
        住,
        行,
        育樂,
        其他,
    }

}
