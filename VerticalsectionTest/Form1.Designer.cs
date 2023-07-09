namespace VerticalsectionTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.纵断面分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成插值点ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.生成纵截面图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算纵断面长度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算纵截面面积ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.横断面分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成插值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成横截面图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算横截面面积ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.纵断面分析ToolStripMenuItem,
            this.横断面分析ToolStripMenuItem,
            this.计算设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.保存文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.保存文件ToolStripMenuItem.Text = "保存文件";
            // 
            // 计算设置ToolStripMenuItem
            // 
            this.计算设置ToolStripMenuItem.Name = "计算设置ToolStripMenuItem";
            this.计算设置ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.计算设置ToolStripMenuItem.Text = "设置";
            this.计算设置ToolStripMenuItem.Click += new System.EventHandler(this.计算设置ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 18);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 401);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "输出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "截面图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(5, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(-4, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(800, 383);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(3, 6);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(788, 372);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // 纵断面分析ToolStripMenuItem
            // 
            this.纵断面分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成插值点ToolStripMenuItem2,
            this.生成纵截面图ToolStripMenuItem,
            this.计算纵断面长度ToolStripMenuItem,
            this.计算纵截面面积ToolStripMenuItem});
            this.纵断面分析ToolStripMenuItem.Name = "纵断面分析ToolStripMenuItem";
            this.纵断面分析ToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.纵断面分析ToolStripMenuItem.Text = "纵断面分析";
            // 
            // 生成插值点ToolStripMenuItem2
            // 
            this.生成插值点ToolStripMenuItem2.Name = "生成插值点ToolStripMenuItem2";
            this.生成插值点ToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.生成插值点ToolStripMenuItem2.Text = "生成插值点";
            this.生成插值点ToolStripMenuItem2.Click += new System.EventHandler(this.生成插值点ToolStripMenuItem_Click);
            // 
            // 生成纵截面图ToolStripMenuItem
            // 
            this.生成纵截面图ToolStripMenuItem.Name = "生成纵截面图ToolStripMenuItem";
            this.生成纵截面图ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.生成纵截面图ToolStripMenuItem.Text = "生成纵截面图";
            this.生成纵截面图ToolStripMenuItem.Click += new System.EventHandler(this.生成纵截面图ToolStripMenuItem_Click);
            // 
            // 计算纵断面长度ToolStripMenuItem
            // 
            this.计算纵断面长度ToolStripMenuItem.Name = "计算纵断面长度ToolStripMenuItem";
            this.计算纵断面长度ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.计算纵断面长度ToolStripMenuItem.Text = "计算纵断面长度";
            this.计算纵断面长度ToolStripMenuItem.Click += new System.EventHandler(this.计算纵断面长度ToolStripMenuItem_Click);
            // 
            // 计算纵截面面积ToolStripMenuItem
            // 
            this.计算纵截面面积ToolStripMenuItem.Name = "计算纵截面面积ToolStripMenuItem";
            this.计算纵截面面积ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.计算纵截面面积ToolStripMenuItem.Text = "计算纵截面面积";
            this.计算纵截面面积ToolStripMenuItem.Click += new System.EventHandler(this.计算纵截面面积ToolStripMenuItem_Click);
            // 
            // 横断面分析ToolStripMenuItem
            // 
            this.横断面分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成插值ToolStripMenuItem,
            this.计算横截面面积ToolStripMenuItem,
            this.生成横截面图ToolStripMenuItem});
            this.横断面分析ToolStripMenuItem.Name = "横断面分析ToolStripMenuItem";
            this.横断面分析ToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.横断面分析ToolStripMenuItem.Text = "横断面分析";
            // 
            // 生成插值ToolStripMenuItem
            // 
            this.生成插值ToolStripMenuItem.Name = "生成插值ToolStripMenuItem";
            this.生成插值ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.生成插值ToolStripMenuItem.Text = "生成插值点";
            this.生成插值ToolStripMenuItem.Click += new System.EventHandler(this.生成插值ToolStripMenuItem_Click);
            // 
            // 生成横截面图ToolStripMenuItem
            // 
            this.生成横截面图ToolStripMenuItem.Name = "生成横截面图ToolStripMenuItem";
            this.生成横截面图ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.生成横截面图ToolStripMenuItem.Text = "生成横截面图";
            // 
            // 计算横截面面积ToolStripMenuItem
            // 
            this.计算横截面面积ToolStripMenuItem.Name = "计算横截面面积ToolStripMenuItem";
            this.计算横截面面积ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.计算横截面面积ToolStripMenuItem.Text = "计算横截面面积";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算设置ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem 纵断面分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成插值点ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 生成纵截面图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算纵断面长度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算纵截面面积ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 横断面分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成插值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成横截面图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算横截面面积ToolStripMenuItem;
    }
}

