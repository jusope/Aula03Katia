namespace Aula03Katia
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
            this.pl = new System.Windows.Forms.Panel();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.plPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.Controls.Add(this.btnProduto);
            this.pl.Controls.Add(this.btnFornecedor);
            this.pl.Controls.Add(this.btnCliente);
            this.pl.Location = new System.Drawing.Point(3, 2);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(170, 513);
            this.pl.TabIndex = 0;
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(9, 278);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(155, 95);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(9, 142);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(155, 95);
            this.btnFornecedor.TabIndex = 1;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(9, 10);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(155, 95);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // plPrincipal
            // 
            this.plPrincipal.Location = new System.Drawing.Point(182, 4);
            this.plPrincipal.Name = "plPrincipal";
            this.plPrincipal.Size = new System.Drawing.Size(888, 510);
            this.plPrincipal.TabIndex = 1;
            this.plPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.plPrincipal_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 520);
            this.Controls.Add(this.plPrincipal);
            this.Controls.Add(this.pl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl;
        private System.Windows.Forms.FlowLayoutPanel plPrincipal;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnCliente;
    }
}

