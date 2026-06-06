namespace CSVAccounting_Progect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            cbxIncome = new CheckBox();
            cmbCategory = new ComboBox();
            label3 = new Label();
            nudAmount = new NumericUpDown();
            label2 = new Label();
            txtNote = new TextBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            panel3 = new Panel();
            lblTotal = new Label();
            lblOutgoing = new Label();
            lblIncoming = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClean = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            dgvItems = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isIncomeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            itemBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbxIncome);
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(nudAmount);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNote);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpDate);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 56);
            panel2.TabIndex = 1;
            // 
            // cbxIncome
            // 
            cbxIncome.AutoSize = true;
            cbxIncome.Location = new Point(869, 14);
            cbxIncome.Name = "cbxIncome";
            cbxIncome.Size = new Size(61, 23);
            cbxIncome.TabIndex = 7;
            cbxIncome.Text = "收入";
            cbxIncome.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(711, 12);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 27);
            cmbCategory.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 16);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 5;
            label3.Text = "類別";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(508, 12);
            nudAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(150, 27);
            nudAmount.TabIndex = 4;
            nudAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 3;
            label2.Text = "金額";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(279, 12);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(176, 27);
            txtNote.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 1;
            label1.Text = "項目";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(11, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(215, 27);
            dtpDate.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(lblOutgoing);
            panel3.Controls.Add(lblIncoming);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnClean);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(btnAdd);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 484);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 69);
            panel3.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(517, 29);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 19);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "結餘:0";
            // 
            // lblOutgoing
            // 
            lblOutgoing.AutoSize = true;
            lblOutgoing.ForeColor = Color.Red;
            lblOutgoing.Location = new Point(432, 28);
            lblOutgoing.Name = "lblOutgoing";
            lblOutgoing.Size = new Size(51, 19);
            lblOutgoing.TabIndex = 7;
            lblOutgoing.Text = "支出:0";
            // 
            // lblIncoming
            // 
            lblIncoming.AutoSize = true;
            lblIncoming.ForeColor = Color.FromArgb(0, 0, 192);
            lblIncoming.Location = new Point(335, 28);
            lblIncoming.Name = "lblIncoming";
            lblIncoming.Size = new Size(51, 19);
            lblIncoming.TabIndex = 6;
            lblIncoming.Text = "收入:0";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(868, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 192);
            btnUpdate.Location = new Point(761, 25);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "更新";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(255, 192, 192);
            btnClean.Location = new Point(655, 25);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(100, 30);
            btnClean.TabIndex = 3;
            btnClean.Text = "清除";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 192);
            btnSave.Location = new Point(116, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(255, 192, 192);
            btnLoad.Location = new Point(222, 25);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "讀取";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Location = new Point(10, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvItems);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 428);
            panel1.TabIndex = 3;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, categoryTypeDataGridViewTextBoxColumn, isIncomeDataGridViewCheckBoxColumn });
            dgvItems.DataSource = itemBindingSource;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(982, 428);
            dgvItems.TabIndex = 0;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "日期";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "事項";
            noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.ReadOnly = true;
            noteDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "金額";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryTypeDataGridViewTextBoxColumn
            // 
            categoryTypeDataGridViewTextBoxColumn.DataPropertyName = "CategoryType";
            categoryTypeDataGridViewTextBoxColumn.HeaderText = "分類";
            categoryTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryTypeDataGridViewTextBoxColumn.Name = "categoryTypeDataGridViewTextBoxColumn";
            categoryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            categoryTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isIncomeDataGridViewCheckBoxColumn
            // 
            isIncomeDataGridViewCheckBoxColumn.DataPropertyName = "IsIncome";
            isIncomeDataGridViewCheckBoxColumn.HeaderText = "收入";
            isIncomeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isIncomeDataGridViewCheckBoxColumn.Name = "isIncomeDataGridViewCheckBoxColumn";
            isIncomeDataGridViewCheckBoxColumn.ReadOnly = true;
            isIncomeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSV記帳APP";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dtpDate;
        private NumericUpDown nudAmount;
        private Label label2;
        private TextBox txtNote;
        private Label label1;
        private ComboBox cmbCategory;
        private Label label3;
        private CheckBox cbxIncome;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClean;
        private Button btnSave;
        private Button btnLoad;
        private Button btnAdd;
        private Panel panel1;
        private DataGridView dgvItems;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryTypeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isIncomeDataGridViewCheckBoxColumn;
        private Label lblOutgoing;
        private Label lblIncoming;
        private Label lblTotal;
    }
}
