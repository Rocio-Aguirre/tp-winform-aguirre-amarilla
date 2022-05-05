using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Aguirre_Amarillo
{
    public partial class frmCargarArticulo : Form
    {
        public frmCargarArticulo()
        {
            InitializeComponent();
        }

        private void fmrCargarArticulo_Load(object sender, EventArgs e)
        {
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");
            cboMarca.Items.Add("Motorola");

            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Televisores");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Audio");

        }
    }
}
