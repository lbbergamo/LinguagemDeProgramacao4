namespace WindowsFormsApp1
{
    partial class form_select
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
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_funcao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(272, 80);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(190, 59);
            this.btn_result.TabIndex = 1;
            this.btn_result.Text = "Grafico de Vendas";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_funcao
            // 
            this.btn_funcao.Location = new System.Drawing.Point(23, 80);
            this.btn_funcao.Name = "btn_funcao";
            this.btn_funcao.Size = new System.Drawing.Size(190, 59);
            this.btn_funcao.TabIndex = 2;
            this.btn_funcao.Text = "Grafico de Função";
            this.btn_funcao.UseVisualStyleBackColor = true;
            this.btn_funcao.Click += new System.EventHandler(this.btn_funcao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o grafico desejado";
            // 
            // form_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_funcao);
            this.Controls.Add(this.btn_result);
            this.Name = "form_select";
            this.Text = "Seleção do Grafico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_funcao;
        private System.Windows.Forms.Label label1;
    }
}

