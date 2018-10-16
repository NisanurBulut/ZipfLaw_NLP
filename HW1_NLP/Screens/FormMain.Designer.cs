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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tblp01 = new System.Windows.Forms.TableLayoutPanel();
            this.LblFlag = new System.Windows.Forms.Label();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.tblp0 = new System.Windows.Forms.TableLayoutPanel();
            this.TabControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChartEn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnZemberekAnalyz = new System.Windows.Forms.Button();
            this.tblp01.SuspendLayout();
            this.tblp0.SuspendLayout();
            this.TabControls.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEn)).BeginInit();
            this.SuspendLayout();
            // 
            // tblp01
            // 
            this.tblp01.ColumnCount = 3;
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblp01.Controls.Add(this.LblFlag, 0, 0);
            this.tblp01.Controls.Add(this.LblDateTime, 0, 0);
            this.tblp01.Controls.Add(this.BtnZemberekAnalyz, 2, 0);
            this.tblp01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp01.Location = new System.Drawing.Point(3, 3);
            this.tblp01.Name = "tblp01";
            this.tblp01.RowCount = 1;
            this.tblp01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp01.Size = new System.Drawing.Size(794, 16);
            this.tblp01.TabIndex = 1;
            // 
            // LblFlag
            // 
            this.LblFlag.AutoSize = true;
            this.LblFlag.Location = new System.Drawing.Point(280, 0);
            this.LblFlag.Name = "LblFlag";
            this.LblFlag.Size = new System.Drawing.Size(35, 13);
            this.LblFlag.TabIndex = 3;
            this.LblFlag.Text = "label1";
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDateTime.Location = new System.Drawing.Point(3, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(271, 16);
            this.LblDateTime.TabIndex = 2;
            this.LblDateTime.Text = "label1";
            // 
            // tblp0
            // 
            this.tblp0.ColumnCount = 1;
            this.tblp0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp0.Controls.Add(this.TabControls, 0, 1);
            this.tblp0.Controls.Add(this.tblp01, 0, 0);
            this.tblp0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp0.Location = new System.Drawing.Point(0, 0);
            this.tblp0.Name = "tblp0";
            this.tblp0.RowCount = 2;
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tblp0.Size = new System.Drawing.Size(800, 450);
            this.tblp0.TabIndex = 0;
            // 
            // TabControls
            // 
            this.TabControls.Controls.Add(this.tabPage1);
            this.TabControls.Controls.Add(this.tabPage2);
            this.TabControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControls.Location = new System.Drawing.Point(3, 25);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedIndex = 0;
            this.TabControls.Size = new System.Drawing.Size(794, 422);
            this.TabControls.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Türkçe Metin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChartEn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İngilizce Metin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChartEn
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartEn.ChartAreas.Add(chartArea1);
            this.ChartEn.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartEn.Legends.Add(legend1);
            this.ChartEn.Location = new System.Drawing.Point(3, 3);
            this.ChartEn.Name = "ChartEn";
            this.ChartEn.Size = new System.Drawing.Size(780, 390);
            this.ChartEn.TabIndex = 0;
            this.ChartEn.Text = "chart1";
            // 
            // BtnZemberekAnalyz
            // 
            this.BtnZemberekAnalyz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnZemberekAnalyz.Location = new System.Drawing.Point(557, 3);
            this.BtnZemberekAnalyz.Name = "BtnZemberekAnalyz";
            this.BtnZemberekAnalyz.Size = new System.Drawing.Size(234, 10);
            this.BtnZemberekAnalyz.TabIndex = 4;
            this.BtnZemberekAnalyz.Text = "Türkçe Kaynak İçin Kelime Analizi Başlat";
            this.BtnZemberekAnalyz.UseVisualStyleBackColor = true;
            this.BtnZemberekAnalyz.Click += new System.EventHandler(this.BtnZemberekAnalyz_Click);
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
            this.TabControls.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartEn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblp01;
        private System.Windows.Forms.Label LblFlag;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.TableLayoutPanel tblp0;
        private System.Windows.Forms.TabControl TabControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartEn;
        private System.Windows.Forms.Button BtnZemberekAnalyz;
    }
}