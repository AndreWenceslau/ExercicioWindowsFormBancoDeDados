using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void btnPeixes_Click(object sender, EventArgs e)
        {
            PeixesForm form = new PeixesForm();
            form.Visible = true;
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            ColaboradoresForm form = new ColaboradoresForm();
            form.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesForm form = new ClientesForm();
            form.Visible = true;
        }
    }
}
