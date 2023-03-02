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

        private void button1_Click(object sender, EventArgs e)
        {
            double vUnit, vTotal, total=0;
            int quan;
            string nome;

            nome = PRODi.Text;
            quan = int.Parse(QUANi.Text);
            vUnit = double.Parse(VALOi.Text);
            vTotal = vUnit * quan;

            dataGridView1.Rows.Add(nome, vUnit, quan, vTotal);

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["TotalG"].Value);
            }

            TotalT.Text = Convert.ToDouble(total).ToString("C");
        }
    }
}
