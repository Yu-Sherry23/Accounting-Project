using System.ComponentModel;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace CSVAccounting_Progect
{
    public partial class Form1 : Form
    {

        private BindingList<Item> items = new BindingList<Item>();



        public Form1()
        {
            InitializeComponent();
            //將enum型態轉換成combox可以讀取的型態
            cmbCategory.DataSource = Enum.GetValues(typeof(Category));
            dgvItems.DataSource = items;

            //建立資料表
            DBHelper.InitDb();

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNote.Text == string.Empty)
            {
                MessageBox.Show("輸入不能為空!", "警告");
                return;
            }
            if (nudAmount.Value <= 0)
            {
                MessageBox.Show("金額輸入不正確", "警告");
                return;
            }




            Item item = new Item();
            item.Date = dtpDate.Value; //Value取質
            item.Note = txtNote.Text;
            item.Amount = nudAmount.Value;
            item.IsIncome = cbxIncome.Checked;
            item.CategoryType = (Category)cmbCategory.SelectedItem;


            DBHelper.InsertItem(item);
            items.Add(item);
            CalcTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                return;
            }
            int index = dgvItems.CurrentRow.Index; //items用位置取質

            if (MessageBox.Show("確定刪除?", "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                items.RemoveAt(index);
                CalcTotal();
            }


        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);

            MessageBox.Show($"點選到第{e.RowIndex + 1}列資料，進入編輯模式");

            Item item = items[e.RowIndex];

            dtpDate.Value = item.Date;
            txtNote.Text = item.Note;
            nudAmount.Value = item.Amount;
            cmbCategory.SelectedItem = item.CategoryType;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                return;
            }
            int index = dgvItems.CurrentRow.Index; //items用位置取質

            if (MessageBox.Show("確定更新嗎?", "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Item item= items[index];
                Item item = new Item();
                item.Date = dtpDate.Value; //Value取質
                item.Note = txtNote.Text;
                item.Amount = nudAmount.Value;
                item.IsIncome = cbxIncome.Checked;
                item.CategoryType = (Category)cmbCategory.SelectedItem;
                items[index] = item;
                CalcTotal();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (items.Count == 0) { return; }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV檔案|*.csv";
            dialog.FileName = "accounting.csv";

            if (dialog.ShowDialog() != DialogResult.OK) return;
            //寫入檔案
            using (StreamWriter sw = new StreamWriter(
                dialog.FileName, false, Encoding.Unicode))
            {
                //寫入第一行標題
                sw.WriteLine("日期,事項,金額,分類,收入");
                foreach (Item item in items)
                {
                    string line = string.Format(

                        "{0},{1},{2},{3},{4}",
                        item.Date.ToString("yyyy/MM/dd hh:mm"), //正確date格式用倒斜線，不能yyyy-MM-dd
                        item.Note,
                        item.Amount,
                        item.CategoryType,
                        item.IsIncome ? "是" : "否" //可換成勾勾
                        );
                    sw.WriteLine(line);
                }


            }



        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            items.Clear();
            var ite = DBHelper.GetAllItems();
            foreach(var item in ite)
            {
             items.Add(item);
            }




            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "CSV檔案|*.csv";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    items.Clear();
            //    string[] lines = File.ReadAllLines(dialog.FileName, Encoding.Unicode);
            //    try
            //    {
            //        for (int i = 1; i < lines.Length; i++)
            //        {
            //            string[] cols = lines[i].Split(",");
            //            if (cols.Length != 5) continue;
            //            Item item = new Item();
            //            item.Date = DateTime.Parse(cols[0]);
            //            item.Note = cols[1];
            //            item.Amount = decimal.Parse(cols[2]);
            //            item.IsIncome = cols[4] == "是" ? true : false;
            //            item.CategoryType = (Category)Enum.Parse(typeof(Category), cols[3]);
            //            items.Add(item);
            //        }
            //        CalcTotal();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"檔案格式部正確:{ex.ToString()}", "錯誤");
            //    }



            //}



        }

        public void CalcTotal()
        {
            decimal incoming = 0, outgoing = 0;

            foreach (var item in items)
            {
                if (item.IsIncome)
                {
                    incoming += item.Amount;
                }
                else
                {
                    outgoing += item.Amount;
                }
            }

            lblIncoming.Text = $"收入:{incoming}";
            lblOutgoing.Text = $"支出:{outgoing}";
            lblTotal.Text= $"結餘:{incoming-outgoing}";

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            items.Clear();
            CalcTotal();
        }
    }
}
