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
            this.tblp0 = new System.Windows.Forms.TableLayoutPanel();
            this.tblp02 = new System.Windows.Forms.TableLayoutPanel();
            this.ChartTr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblp01 = new System.Windows.Forms.TableLayoutPanel();
            this.LblFlag = new System.Windows.Forms.Label();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.tblp0.SuspendLayout();
            this.tblp02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTr)).BeginInit();
            this.tblp01.SuspendLayout();
            this.SuspendLayout();
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
            this.tblp0.RowCount = 3;
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblp0.Size = new System.Drawing.Size(800, 450);
            this.tblp0.TabIndex = 0;
            // 
            // tblp02
            // 
            this.tblp02.ColumnCount = 1;
            this.tblp02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp02.Controls.Add(this.ChartTr, 0, 0);
            this.tblp02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp02.Location = new System.Drawing.Point(3, 25);
            this.tblp02.Name = "tblp02";
            this.tblp02.RowCount = 2;
            this.tblp02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblp02.Size = new System.Drawing.Size(794, 399);
            this.tblp02.TabIndex = 0;
            // 
            // ChartTr
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.ChartTr.ChartAreas.Add(chartArea1);
            this.ChartTr.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartTr.Legends.Add(legend1);
            this.ChartTr.Location = new System.Drawing.Point(3, 3);
            this.ChartTr.Name = "ChartTr";
            this.ChartTr.Size = new System.Drawing.Size(788, 193);
            this.ChartTr.TabIndex = 0;
            this.ChartTr.Text = "chart1";
            this.ChartTr.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.ChartTr_GetToolTipText);
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
            this.tblp01.Size = new System.Drawing.Size(794, 16);
            this.tblp01.TabIndex = 1;
            // 
            // LblFlag
            // 
            this.LblFlag.AutoSize = true;
            this.LblFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFlag.Location = new System.Drawing.Point(400, 0);
            this.LblFlag.Name = "LblFlag";
            this.LblFlag.Size = new System.Drawing.Size(391, 16);
            this.LblFlag.TabIndex = 3;
            this.LblFlag.Text = "label1";
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDateTime.Location = new System.Drawing.Point(3, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(391, 16);
            this.LblDateTime.TabIndex = 2;
            this.LblDateTime.Text = "label1";
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
            this.tblp0.ResumeLayout(false);
            this.tblp02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTr)).EndInit();
            this.tblp01.ResumeLayout(false);
            this.tblp01.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblp0;
        private System.Windows.Forms.TableLayoutPanel tblp02;
        private System.Windows.Forms.TableLayoutPanel tblp01;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.Label LblFlag;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTr;
    }
}