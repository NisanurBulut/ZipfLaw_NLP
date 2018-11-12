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
            this.BtnComboSelect = new System.Windows.Forms.Button();
            this.LblFlag = new System.Windows.Forms.Label();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.BtnZemberekAnalyz = new System.Windows.Forms.Button();
            this.comboBooks = new System.Windows.Forms.ComboBox();
            this.tblp0 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.tblp01.SuspendLayout();
            this.tblp0.SuspendLayout();
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
            this.tblp01.Controls.Add(this.BtnComboSelect, 1, 0);
            this.tblp01.Controls.Add(this.LblFlag, 2, 0);
            this.tblp01.Controls.Add(this.LblDateTime, 2, 0);
            this.tblp01.Controls.Add(this.BtnZemberekAnalyz, 4, 0);
            this.tblp01.Controls.Add(this.comboBooks, 0, 0);
            this.tblp01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp01.Location = new System.Drawing.Point(3, 3);
            this.tblp01.Name = "tblp01";
            this.tblp01.RowCount = 1;
            this.tblp01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp01.Size = new System.Drawing.Size(794, 17);
            this.tblp01.TabIndex = 1;
            // 
            // BtnComboSelect
            // 
            this.BtnComboSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnComboSelect.Location = new System.Drawing.Point(161, 3);
            this.BtnComboSelect.Name = "BtnComboSelect";
            this.BtnComboSelect.Size = new System.Drawing.Size(152, 11);
            this.BtnComboSelect.TabIndex = 6;
            this.BtnComboSelect.Text = "Oku\r\n";
            this.BtnComboSelect.UseVisualStyleBackColor = true;
            this.BtnComboSelect.Click += new System.EventHandler(this.BtnComboSelect_Click);
            // 
            // LblFlag
            // 
            this.LblFlag.AutoSize = true;
            this.LblFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFlag.Location = new System.Drawing.Point(477, 0);
            this.LblFlag.Name = "LblFlag";
            this.LblFlag.Size = new System.Drawing.Size(152, 17);
            this.LblFlag.TabIndex = 3;
            this.LblFlag.Text = "label1";
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Location = new System.Drawing.Point(319, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(35, 13);
            this.LblDateTime.TabIndex = 2;
            this.LblDateTime.Text = "label1";
            // 
            // BtnZemberekAnalyz
            // 
            this.BtnZemberekAnalyz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnZemberekAnalyz.Location = new System.Drawing.Point(635, 3);
            this.BtnZemberekAnalyz.Name = "BtnZemberekAnalyz";
            this.BtnZemberekAnalyz.Size = new System.Drawing.Size(156, 11);
            this.BtnZemberekAnalyz.TabIndex = 4;
            this.BtnZemberekAnalyz.Text = "Türkçe Kaynak İçin Kelime Analizi Başlat";
            this.BtnZemberekAnalyz.UseVisualStyleBackColor = true;
            this.BtnZemberekAnalyz.Click += new System.EventHandler(this.BtnZemberekAnalyz_Click);
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
            this.comboBooks.Size = new System.Drawing.Size(152, 21);
            this.comboBooks.TabIndex = 5;
            // 
            // tblp0
            // 
            this.tblp0.ColumnCount = 1;
            this.tblp0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp0.Controls.Add(this.elementHost1, 0, 1);
            this.tblp0.Controls.Add(this.tblp01, 0, 0);
            this.tblp0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp0.Location = new System.Drawing.Point(0, 0);
            this.tblp0.Name = "tblp0";
            this.tblp0.RowCount = 2;
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblp0.Size = new System.Drawing.Size(800, 450);
            this.tblp0.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 26);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(794, 421);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblp0);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tblp01.ResumeLayout(false);
            this.tblp01.PerformLayout();
            this.tblp0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblp01;
        private System.Windows.Forms.Label LblFlag;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.TableLayoutPanel tblp0;
        private System.Windows.Forms.Button BtnZemberekAnalyz;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Button BtnComboSelect;
        private System.Windows.Forms.ComboBox comboBooks;
        private LiveCharts.Wpf.PieChart pieChart1;
    }
}