using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            PRODi.Clear();
            QUANi.Clear();
            VALOi.Clear();
            PRODi.Focus();
        }

        private void CalculaTotal()
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["TotalG"].Value);
            }

            TotalT.Text = Convert.ToDouble(total).ToString("C");
        }

        private bool VerificaCampo()
        {
            if (PRODi.Text == "" || QUANi.Text == "" || VALOi.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vUnit, vTotal;
            int quan;
            string nome;
            bool x = VerificaCampo();
            
            if (x)
            {
                nome = PRODi.Text;
                quan = int.Parse(QUANi.Text);
                vUnit = double.Parse(VALOi.Text);
                vTotal = vUnit * quan;

                dataGridView1.Rows.Add(nome, vUnit, quan, vTotal);

                CalculaTotal();

                Limpar();
            }
            else
            {
                MessageBox.Show("Campos em branco");
            }

        }

        private void VALOi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                e.Handled = true;
                }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {   
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                CalculaTotal();
            }   
            catch
            {
                MessageBox.Show("Campo vazio");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
