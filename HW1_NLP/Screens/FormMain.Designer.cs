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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tblp01 = new System.Windows.Forms.TableLayoutPanel();
            this.LblFlag = new System.Windows.Forms.Label();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.tblp0 = new System.Windows.Forms.TableLayoutPanel();
            this.tblp02 = new System.Windows.Forms.TableLayoutPanel();
            this.TabControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChartTr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChartEn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblp01.SuspendLayout();
            this.tblp0.SuspendLayout();
            this.tblp02.SuspendLayout();
            this.TabControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTr)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartEn)).BeginInit();
            this.SuspendLayout();
            // 
            // tblp01
            // 
            this.tblp01.ColumnCount = 2;
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp01.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp01.Controls.Add(this.LblFlag, 0, 0);
            this.tblp01.Controls.Add(this.LblDateTime, 0, 0);
            this.tblp01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp01.Location = new System.Drawing.Point(3, 3);
            this.tblp01.Name = "tblp01";
            this.tblp01.RowCount = 1;
            this.tblp01.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp01.Size = new System.Drawing.Size(794, 7);
            this.tblp01.TabIndex = 1;
            // 
            // LblFlag
            // 
            this.LblFlag.AutoSize = true;
            this.LblFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFlag.Location = new System.Drawing.Point(400, 0);
            this.LblFlag.Name = "LblFlag";
            this.LblFlag.Size = new System.Drawing.Size(391, 7);
            this.LblFlag.TabIndex = 3;
            this.LblFlag.Text = "label1";
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDateTime.Location = new System.Drawing.Point(3, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(391, 7);
            this.LblDateTime.TabIndex = 2;
            this.LblDateTime.Text = "label1";
            // 
            // tblp0
            // 
            this.tblp0.ColumnCount = 1;
            this.tblp0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp0.Controls.Add(this.tblp02, 0, 1);
            this.tblp0.Controls.Add(this.tblp01, 0, 0);
            this.tblp0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp0.Location = new System.Drawing.Point(0, 0);
            this.tblp0.Name = "tblp0";
            this.tblp0.RowCount = 2;
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.tblp0.Size = new System.Drawing.Size(800, 450);
            this.tblp0.TabIndex = 0;
            // 
            // tblp02
            // 
            this.tblp02.ColumnCount = 1;
            this.tblp02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp02.Controls.Add(this.TabControls, 0, 0);
            this.tblp02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp02.Location = new System.Drawing.Point(3, 16);
            this.tblp02.Name = "tblp02";
            this.tblp02.RowCount = 1;
            this.tblp02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp02.Size = new System.Drawing.Size(794, 431);
            this.tblp02.TabIndex = 0;
            // 
            // TabControls
            // 
            this.TabControls.Controls.Add(this.tabPage1);
            this.TabControls.Controls.Add(this.tabPage2);
            this.TabControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControls.Location = new System.Drawing.Point(3, 3);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedIndex = 0;
            this.TabControls.Size = new System.Drawing.Size(788, 425);
            this.TabControls.TabIndex = 0;
            this.TabControls.SelectedIndexChanged += new System.EventHandler(this.TabControls_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChartTr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Türkçe Metin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChartTr
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.ChartTr.ChartAreas.Add(chartArea3);
            this.ChartTr.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.ChartTr.Legends.Add(legend3);
            this.ChartTr.Location = new System.Drawing.Point(3, 3);
            this.ChartTr.Name = "ChartTr";
            this.ChartTr.Size = new System.Drawing.Size(774, 393);
            this.ChartTr.TabIndex = 1;
            this.ChartTr.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChartEn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İngilizce Metin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChartEn
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartEn.ChartAreas.Add(chartArea4);
            this.ChartEn.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.ChartEn.Legends.Add(legend4);
            this.ChartEn.Location = new System.Drawing.Point(3, 3);
            this.ChartEn.Name = "ChartEn";
            this.ChartEn.Size = new System.Drawing.Size(774, 393);
            this.ChartEn.TabIndex = 0;
            this.ChartEn.Text = "chart1";
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
            this.tblp02.ResumeLayout(false);
            this.TabControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTr)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartEn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblp01;
        private System.Windows.Forms.Label LblFlag;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.TableLayoutPanel tblp0;
        private System.Windows.Forms.TableLayoutPanel tblp02;
        private System.Windows.Forms.TabControl TabControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTr;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartEn;
    }
}