namespace HW1_NLP.Screens
{
    partial class FormMain
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
            this.tblp01 = new System.Windows.Forms.TableLayoutPanel();
            this.LblFlag = new System.Windows.Forms.Label();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.comboBooks = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tblp0 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tblp01.SuspendLayout();
            this.tblp0.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblp01
            // 
            this.tblp01.ColumnCount = 5;
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblp01.Controls.Add(this.LblFlag, 2, 0);
            this.tblp01.Controls.Add(this.LblDateTime, 2, 0);
            this.tblp01.Controls.Add(this.comboBooks, 0, 0);
            this.tblp01.Controls.Add(this.comboBox1, 1, 0);
            this.tblp01.Controls.Add(this.button1, 4, 0);
            this.tblp01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp01.Location = new System.Drawing.Point(3, 3);
            this.tblp01.Name = "tblp01";
            this.tblp01.RowCount = 1;
            this.tblp01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp01.Size = new System.Drawing.Size(977, 21);
            this.tblp01.TabIndex = 1;
            // 
            // LblFlag
            // 
            this.LblFlag.AutoSize = true;
            this.LblFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFlag.Location = new System.Drawing.Point(393, 0);
            this.LblFlag.Name = "LblFlag";
            this.LblFlag.Size = new System.Drawing.Size(189, 21);
            this.LblFlag.TabIndex = 3;
            this.LblFlag.Text = "label1";
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Location = new System.Drawing.Point(588, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(35, 13);
            this.LblDateTime.TabIndex = 2;
            this.LblDateTime.Text = "label1";
            // 
            // comboBooks
            // 
            this.comboBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBooks.FormattingEnabled = true;
            this.comboBooks.Items.AddRange(new object[] {
            "HarryPotterKitap1Tr.txt",
            "HarryPotterBook1En.txt"});
            this.comboBooks.Location = new System.Drawing.Point(3, 3);
            this.comboBooks.Name = "comboBooks";
            this.comboBooks.Size = new System.Drawing.Size(189, 21);
            this.comboBooks.TabIndex = 5;
            this.comboBooks.SelectedIndexChanged += new System.EventHandler(this.comboBooks_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sabit Sayı Gösterimi(fxr=c)",
            "Sıklık oran Gösterimi",
            "Olasılık Dağılım Gösterimi(f/r)"});
            this.comboBox1.Location = new System.Drawing.Point(198, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(783, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 15);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ek Dağılım Olasılığını Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblp0
            // 
            this.tblp0.ColumnCount = 1;
            this.tblp0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp0.Controls.Add(this.tblp01, 0, 0);
            this.tblp0.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblp0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp0.Location = new System.Drawing.Point(0, 0);
            this.tblp0.Name = "tblp0";
            this.tblp0.RowCount = 2;
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblp0.Size = new System.Drawing.Size(983, 529);
            this.tblp0.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 496);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(198, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(776, 490);
            this.elementHost1.TabIndex = 5;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 490);
            this.listBox1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 529);
            this.Controls.Add(this.tblp0);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tblp01.ResumeLayout(false);
            this.tblp01.PerformLayout();
            this.tblp0.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblp01;
        private System.Windows.Forms.Label LblFlag;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.TableLayoutPanel tblp0;
        private System.Windows.Forms.ComboBox comboBooks;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}