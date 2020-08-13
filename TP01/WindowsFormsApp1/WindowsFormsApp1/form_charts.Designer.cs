namespace WindowsFormsApp1
{
    partial class form_charts
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.title_calc = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "Chart";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(12, 69);
            this.chart.Name = "chart";
            series1.ChartArea = "Chart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(747, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "Grafico";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(36, 42);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(50, 20);
            this.tb_y.TabIndex = 1;
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(125, 42);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(44, 20);
            this.tb_x.TabIndex = 1;
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(16, 46);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(14, 13);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "Y";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(105, 46);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(14, 13);
            this.label_x.TabIndex = 2;
            this.label_x.Text = "X";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(205, 40);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // title_calc
            // 
            this.title_calc.AutoSize = true;
            this.title_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_calc.Location = new System.Drawing.Point(15, 9);
            this.title_calc.Name = "title_calc";
            this.title_calc.Size = new System.Drawing.Size(158, 24);
            this.title_calc.TabIndex = 4;
            this.title_calc.Text = "Calculo de F(X)";
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(501, 23);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(111, 36);
            this.btn_import.TabIndex = 5;
            this.btn_import.Text = "Importar";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(648, 23);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(111, 36);
            this.clean.TabIndex = 5;
            this.clean.Text = "Limpar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // form_charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 386);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.title_calc);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.chart);
            this.Name = "form_charts";
            this.Text = "form_charts";
            this.Deactivate += new System.EventHandler(this.form_charts_Deactivate);
            this.Load += new System.EventHandler(this.form_charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label title_calc;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button clean;
    }
}