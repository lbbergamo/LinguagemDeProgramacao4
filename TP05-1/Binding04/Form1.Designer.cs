namespace Binding04
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtro = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDVendasDataSet = new Binding04.BDVendasDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabVendedorVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabVendedorVendasTableAdapter = new Binding04.BDVendasDataSetTableAdapters.TabVendedorVendasTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_vendas = new System.Windows.Forms.TextBox();
            this.cb_vendas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVendedorVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(144, 260);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // btn_filtro
            // 
            this.btn_filtro.Location = new System.Drawing.Point(289, 258);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(75, 23);
            this.btn_filtro.TabIndex = 3;
            this.btn_filtro.Text = "Filtrar";
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bDVendasDataSet;
            this.bindingSource1.Position = 0;
            // 
            // bDVendasDataSet
            // 
            this.bDVendasDataSet.DataSetName = "BDVendasDataSet";
            this.bDVendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.vendasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabVendedorVendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 239);
            this.dataGridView1.TabIndex = 4;
            // 
            // tabVendedorVendasBindingSource
            // 
            this.tabVendedorVendasBindingSource.DataMember = "TabVendedorVendas";
            this.tabVendedorVendasBindingSource.DataSource = this.bindingSource1;
            // 
            // tabVendedorVendasTableAdapter
            // 
            this.tabVendedorVendasTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            // 
            // vendasDataGridViewTextBoxColumn
            // 
            this.vendasDataGridViewTextBoxColumn.DataPropertyName = "Vendas";
            this.vendasDataGridViewTextBoxColumn.HeaderText = "Vendas";
            this.vendasDataGridViewTextBoxColumn.Name = "vendasDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendas";
            // 
            // tb_vendas
            // 
            this.tb_vendas.Location = new System.Drawing.Point(144, 292);
            this.tb_vendas.Name = "tb_vendas";
            this.tb_vendas.Size = new System.Drawing.Size(100, 20);
            this.tb_vendas.TabIndex = 1;
            this.tb_vendas.TextChanged += new System.EventHandler(this.tb_vendas_TextChanged);
            // 
            // cb_vendas
            // 
            this.cb_vendas.FormattingEnabled = true;
            this.cb_vendas.Items.AddRange(new object[] {
            "=",
            ">=",
            "<=",
            "<>"});
            this.cb_vendas.Location = new System.Drawing.Point(250, 291);
            this.cb_vendas.Name = "cb_vendas";
            this.cb_vendas.Size = new System.Drawing.Size(47, 21);
            this.cb_vendas.TabIndex = 5;
            this.cb_vendas.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 320);
            this.Controls.Add(this.cb_vendas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_vendas);
            this.Controls.Add(this.tb_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVendedorVendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BDVendasDataSet bDVendasDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tabVendedorVendasBindingSource;
        private BDVendasDataSetTableAdapters.TabVendedorVendasTableAdapter tabVendedorVendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_vendas;
        private System.Windows.Forms.ComboBox cb_vendas;
    }
}

