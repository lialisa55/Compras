
namespace Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.VALOi = new System.Windows.Forms.TextBox();
            this.QUANi = new System.Windows.Forms.TextBox();
            this.PRODi = new System.Windows.Forms.TextBox();
            this.TotalT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.ValUnit,
            this.Quan,
            this.TotalG});
            this.dataGridView1.Location = new System.Drawing.Point(42, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor unitário";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VALOi
            // 
            this.VALOi.Location = new System.Drawing.Point(253, 41);
            this.VALOi.Name = "VALOi";
            this.VALOi.Size = new System.Drawing.Size(100, 20);
            this.VALOi.TabIndex = 5;
            // 
            // QUANi
            // 
            this.QUANi.Location = new System.Drawing.Point(381, 41);
            this.QUANi.Name = "QUANi";
            this.QUANi.Size = new System.Drawing.Size(100, 20);
            this.QUANi.TabIndex = 6;
            // 
            // PRODi
            // 
            this.PRODi.Location = new System.Drawing.Point(42, 41);
            this.PRODi.Name = "PRODi";
            this.PRODi.Size = new System.Drawing.Size(192, 20);
            this.PRODi.TabIndex = 7;
            // 
            // TotalT
            // 
            this.TotalT.Location = new System.Drawing.Point(485, 320);
            this.TotalT.Name = "TotalT";
            this.TotalT.Size = new System.Drawing.Size(100, 20);
            this.TotalT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // ValUnit
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ValUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValUnit.HeaderText = "Valor unitário";
            this.ValUnit.Name = "ValUnit";
            this.ValUnit.Width = 125;
            // 
            // Quan
            // 
            this.Quan.HeaderText = "Quantidade";
            this.Quan.Name = "Quan";
            this.Quan.Width = 125;
            // 
            // TotalG
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.TotalG.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalG.HeaderText = "Total";
            this.TotalG.Name = "TotalG";
            this.TotalG.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 356);
            this.Controls.Add(this.TotalT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PRODi);
            this.Controls.Add(this.QUANi);
            this.Controls.Add(this.VALOi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VALOi;
        private System.Windows.Forms.TextBox QUANi;
        private System.Windows.Forms.TextBox PRODi;
        private System.Windows.Forms.TextBox TotalT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalG;
    }
}

